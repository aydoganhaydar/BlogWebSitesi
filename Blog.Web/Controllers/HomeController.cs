using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Model.Entities.Concrete;
using Blog.Model.Entities.Enums;
using Blog.Web.Models;
using Blog.Web.Models.DTOs;
using Blog.Web.Models.VMs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace Blog.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IArticleRepository _articleRepository;
        private readonly IAdminRepository<Admin> _adminRepository;
        private readonly IAppUserRepository _appUserRepository;
        private readonly ICategoryReporsitory _categoryReporsitory;

        public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IArticleRepository articleRepository,IAdminRepository<Admin> adminRepository,IAppUserRepository appUserRepository,ICategoryReporsitory categoryReporsitory)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            _articleRepository = articleRepository;
            _adminRepository = adminRepository;
            _appUserRepository = appUserRepository;
            _categoryReporsitory = categoryReporsitory;
        }
        public IActionResult Login()
        {
            return View();  
        }

        [HttpPost]

        public  async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            if (ModelState.IsValid)
            {
                IdentityUser identityUser = await _userManager.FindByEmailAsync(loginDTO.Mail);
                if (identityUser!=null)
                {
                    await _signInManager.SignOutAsync(); // içerde cookide kalanları temizliyor.

                    SignInResult result = await _signInManager.PasswordSignInAsync(identityUser, loginDTO.Password, true, true);
                    
                    if(result.Succeeded)
                    {
                        AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);

                        if (appUser.Onay==Onay.Approved)
                        {
                            return RedirectToAction("Index", "AppUser", new { area = "Member" }); // Kayıtlı kullanıcı anasayfasına yönlendirme yaptık.
                        }
                        else 
                        {
                            return RedirectToAction("Onayy", "Home");
                        }
                            

                    }
                    else return RedirectToAction("NotLogin", "Home");



                }
            }
            return View(loginDTO);
        }

        public IActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminLogin(AdminLoginDTO adminLoginDTO)
        {
            if (ModelState.IsValid)
            {
                var admin = _adminRepository.GetDefault
                    (
                        expression:a=>a.Mail==adminLoginDTO.Mail && a.Password==adminLoginDTO.Password
                    );

                if (admin!=null)
                {
                    return RedirectToAction("Index", "Adminn", new { area = "Adminn"}); // Admin anasayfasına yönlendirme yaptık.
                }
                else

                    return RedirectToAction("Index", "Home"); 
            }
            return View(adminLoginDTO);
           
            
        }






        public IActionResult Index()
        {
            var categoryList = _categoryReporsitory.GetDefaults(a => a.Statu != Statu.Passive && a.Onay==Onay.Approved);
            var appUserList=_appUserRepository.GetDefaults(a=>a.Statu!=Statu.Passive && a.Onay == Onay.Approved);
            var articlesList=_articleRepository.GetDefaults(a=>a.Statu != Statu.Passive && a.Onay == Onay.Approved);
            return View(Tuple.Create(categoryList,appUserList,articlesList));


            
        }

        public IActionResult Hakkimizda()
        {
            var categoryList = _categoryReporsitory.GetDefaults(a => a.Statu != Statu.Passive && a.Onay == Onay.Approved);
            var appUserList = _appUserRepository.GetDefaults(a => a.Statu != Statu.Passive && a.Onay == Onay.Approved);
            var articlesList = _articleRepository.GetDefaults(a => a.Statu != Statu.Passive && a.Onay == Onay.Approved);
            return View(Tuple.Create(categoryList, appUserList, articlesList));
          
        }

        public IActionResult Onayy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult NotLogin()
        {
            return View();
        }
    }
}
