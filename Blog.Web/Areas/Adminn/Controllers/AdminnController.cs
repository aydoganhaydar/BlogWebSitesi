using Blog.Dal.Repositories.Concrete;
using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Model.Entities.Concrete;
using Blog.Model.Entities.Enums;
using Blog.Web.Models.DTOs;
using Blog.Web.Models.VMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.Areas.Adminn.Controllers
{
    [Area("Adminn")]
    
    public class AdminnController : Controller
    {
        private readonly IAdminRepository<Admin> _adminRepository;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IArticleRepository _articleRepository;

        public AdminnController(IAdminRepository<Admin> adminRepository, SignInManager<IdentityUser> signInManager, IArticleRepository articleRepository)
        {
            _adminRepository = adminRepository;
            _signInManager = signInManager;
            _articleRepository = articleRepository;
        }
        public IActionResult Index(Admin adminn)
        {
            var admin = _adminRepository.GetDefault
                    (
            expression: a => a.Mail == adminn.Mail && a.Password == adminn.Password
                    );

            List<GetArticleWithUsersVM> listem = _articleRepository.GetByDefaults
                (
                   selector: a => new GetArticleWithUsersVM()
                   {
                       Title = a.Title,
                       Content = a.Content,
                       CreatedDate = a.CreatedDate,
                       ArticleID = a.ID,
                       Image = a.Image,
                       Likes = a.Likes,
                       Comments = a.Comments,
                       UserFullName = a.AppUser.FullName,
                       AppUserID = a.AppUserID,
                       CategoryId = a.CategoryID,
                       CategoryName = a.Category.Name,
                   },
                   expression: a => a.Statu != Statu.Passive && a.Onay == Onay.Approved,
                   include: a => a.Include(a => a.AppUser).Include(b => b.Category),
                   orderBy: a => a.OrderByDescending(a => a.CreatedDate)
                ).ToList();

            return View(Tuple.Create(admin, listem));


        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");

        }
    }
}
