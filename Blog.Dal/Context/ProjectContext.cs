using Blog.Model.Entities.Concrete;
using Blog.Model.TypeConfiguration.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Dal.Context
{
    public class ProjectContext :IdentityDbContext
    {

        // Connectionstring appseting.json da yazılacağı için burada yazmadık.
        public ProjectContext(DbContextOptions options) :base(options){ }

        // Veri tabanı tarafında ayağa kalkmasını isteğimiz tablolar.

        public DbSet <Admin> Admin { get; set; }
        public DbSet<Article> Articles { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Like> Likes { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<UserFollwedCategories> UserFollwedCategories { get; set; }

        public DbSet<AppUserPasswords> AppUserPasswords { get; set; }

        public DbSet<ArticleCategory> ArticleCategories { get; set; }

        // Yaptığımız konfigurasyonlar
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AdminMap());
            builder.ApplyConfiguration(new AppUserMap());
            builder.ApplyConfiguration(new ArticleMap());
            builder.ApplyConfiguration(new CommentMap());
            builder.ApplyConfiguration(new IdentityRoleMap());
            builder.ApplyConfiguration(new LikeMap());
            builder.ApplyConfiguration(new UserFollwedCategoryMap());
            builder.ApplyConfiguration(new AppUserPasswordMap());
            builder.ApplyConfiguration(new ArticleCategoryMap());

            base.OnModelCreating(builder);
        }










    }
}
