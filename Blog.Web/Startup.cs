using Blog.Dal.Context;
using Blog.Dal.Repositories.Concrete;
using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Web.Models.Mapping;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Blog.Model.Entities.Concrete;

namespace Blog.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<ProjectContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Default")));
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ProjectContext>();
            services.AddAutoMapper(typeof(MappingWithMapper));

            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<ICategoryReporsitory, CategoryRepository>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<ILikeRepository, LikeRepository>();
            services.AddScoped<IAdminRepository<Admin>, AdminRepository<Admin>>();
            services.AddScoped<IUserFollwedCategoriesRepository, UserFollwedCategoriesRepository>();
            services.AddScoped<IAppUserPasswordsRepository, AppUserPasswordsRepository>();

            services.ConfigureApplicationCookie(a =>
            {
                a.LoginPath = new PathString("/Home/Login"); // kullanýcý home controllerin login actionun dan geliyorsa onu içeri al.
                a.ExpireTimeSpan = TimeSpan.FromDays(1); // cooki tanýmlama süresi. 1 gün boyunca kullanýcýyý hatýrlayacak.
                a.Cookie = new CookieBuilder { Name = "KullaniciCookie", SecurePolicy = CookieSecurePolicy.Always }; // cookie mizi isimlendirdik.
            });

            services.ConfigureApplicationCookie(a =>
            {
                a.LoginPath = new PathString("/Home/AdminLogin"); // kullanýcý home controllerin Adminlogin actionun dan geliyorsa onu içeri al.
                a.ExpireTimeSpan = TimeSpan.FromDays(1); // cooki tanýmlama süresi. 1 gün boyunca kullanýcýyý hatýrlayacak.
                a.Cookie = new CookieBuilder { Name = "AdminCookie", SecurePolicy = CookieSecurePolicy.Always }; // cookie mizi isimlendirdik.
            });

            services.AddAuthentication();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "area", pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
