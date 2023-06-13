using Blog.Dal.Repositories.Interfaces.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Blog.Model.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using Blog.Dal.Repositories.Concrete;
using Blog.Web.Models.VMs;
using System.Collections.Generic;
using Blog.Web.Areas.Member.Models.DTOs;
using System;
using System.IO;
using Blog.Model.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Blog.Web.Areas.Member.Models.VMs;
using AutoMapper;
using Newtonsoft.Json.Schema;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using Microsoft.AspNetCore.Hosting.Server;
using Grpc.Core;
using System.Linq;

namespace Blog.Web.Areas.Member.Controllers
{
    [Area("Member")]

    public class AppUserController
        : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IAppUserRepository _appUserRepository;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IMapper _mapper;
        private readonly ICategoryReporsitory _categoryReporsitory;
        private readonly IArticleRepository _articleRepository;
        private readonly IAppUserPasswordsRepository _appUserPasswordsRepository;

        public AppUserController(UserManager<IdentityUser> userManager, IAppUserRepository appUserRepository, SignInManager<IdentityUser> signInManager, IMapper mapper, ICategoryReporsitory categoryReporsitory, IArticleRepository articleRepository, IAppUserPasswordsRepository appUserPasswordsRepository)
        {
            _userManager = userManager;
            _appUserRepository = appUserRepository;
            _signInManager = signInManager;
            _mapper = mapper;
            _categoryReporsitory = categoryReporsitory;
            _articleRepository = articleRepository;
            _appUserPasswordsRepository = appUserPasswordsRepository;
        }

        public async Task<IActionResult> Index()
        {

            IdentityUser identityUser = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);

            if (identityUser != null)
            {
                var categoryList = _categoryReporsitory.GetDefaults(a => a.Statu != Statu.Passive && a.Onay == Onay.Approved);
                var appUserList = _appUserRepository.GetDefaults(a => a.Statu != Statu.Passive && a.Onay == Onay.Approved);
                var articlesList = _articleRepository.GetDefaults(a => a.Statu != Statu.Passive && a.Onay == Onay.Approved);
                return View(Tuple.Create(categoryList, appUserList, articlesList, appUser));
            }
            else 
            { 
                return Redirect("~/"); // RedirectToAction ("Index", "Home");
            }



        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");

        }

        public async Task<IActionResult> AppUserDetail(int id)
        {
            IdentityUser ıdentityUser = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == ıdentityUser.Id);

            var appUser1 = _appUserRepository.GetByDefault
                (
                    selector: a => new AppUserDetailVM()
                    {
                        AppUserID = a.ID,
                        IdentityID = a.IdentityId,
                        FullName = a.FullName,
                        Mail = ıdentityUser.Email,
                        Image = a.Image,
                        Address = a.Address,
                        WebSite = a.WebSite,
                        GitHub = a.GitHub,
                        Twitter = a.Twitter,
                        Instagram = a.Instagram,
                        Facebook = a.Facebook,
                        Articles = a.Articles,
                        Likes = a.Likes,
                        CookieID = appUser.ID,

                    },
                    expression: a => a.Statu != Statu.Passive && a.ID == id,
                    include: a => a.Include(a => a.Articles).Include(a => a.Likes)

                );
            return View(appUser1);
        }

        public async Task<IActionResult> ProfileDetail()
        {
            IdentityUser ıdentityUser = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == ıdentityUser.Id);

            var appUser1 = _appUserRepository.GetByDefault
                (
                    selector: a => new AppUserProfileVM()
                    {
                        AppUserID = appUser.ID,
                        IdentityID = a.IdentityId,
                        FirstName = a.FirstName,
                        LastName = a.LastName,
                        UserName = a.UserName,
                        Password = a.Password,
                        Mail = ıdentityUser.Email,
                        Image = a.Image,
                        Address = a.Address,
                        WebSite = a.WebSite,
                        GitHub = a.GitHub,
                        Twitter = a.Twitter,
                        Instagram = a.Instagram,
                        Facebook = a.Facebook,
                    },
                    expression: a => a.ID == appUser.ID,
                    include: a => a.Include(a => a.Articles).Include(a => a.Likes)

                );
            return View(appUser1);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            IdentityUser ıdentityUser = await _userManager.GetUserAsync(User);

            var appUser = _appUserRepository.GetByDefault
                (
                    selector: a => new AppUserUpdateDTO()
                    {
                        ID = a.ID,
                        IdentityId = ıdentityUser.Id,
                        FirstName = a.FirstName,
                        LastName = a.LastName,
                        UserName = a.UserName,
                        Password = a.Password,
                        Mail = ıdentityUser.Email,
                        Image = a.Image,
                        Address = a.Address,
                        WebSite = a.WebSite,
                        GitHub = a.GitHub,
                        Twitter = a.Twitter,
                        Instagram = a.Instagram,
                        Facebook = a.Facebook,
                    },
                    expression: a => a.ID == id
                );

            var updateAppUser = _mapper.Map<AppUserUpdateDTO>(appUser);
            

            return View(updateAppUser);
        }

        [HttpPost]
        public async Task<IActionResult> Update(AppUserUpdateDTO dto)
        {
            List<AppUserPasswords> appUserPasswords = _appUserPasswordsRepository.GetDefaults(a => a.AppUserID == dto.ID).OrderByDescending(a=>a.CreatedDate).Take(3).ToList();
            if (ModelState.IsValid)
            {
                foreach (var item in appUserPasswords)
                {
                    if (item.Password==dto.Password)
                    {
                        return RedirectToAction("SifreUyari", "AppUser", new { area = "Member" });
                    }
                    AppUserPasswords appUserPasswords1=new AppUserPasswords { AppUserID=dto.ID, Password=dto.Password};
                    var appUserPassword = _mapper.Map<AppUserPasswords>(appUserPasswords1);
                    _appUserPasswordsRepository.Create(appUserPassword);

                    IdentityUser ıdentityUser = await _userManager.GetUserAsync(User);
                    ıdentityUser.PasswordHash = _userManager.PasswordHasher.HashPassword(ıdentityUser, dto.Password);
                    var appUser = _mapper.Map<AppUser>(dto);
                    System.IO.File.Delete($"wwwroot/images/{appUser.UserName}.jpg");
                    using var image = Image.Load(dto.ImagePath.OpenReadStream()); // fotoğraf okuyup yükledik.
                    image.Save($"wwwroot/images/{appUser.UserName}.jpg");
                    appUser.Image = $"/images/{appUser.UserName}.jpg";

                    _appUserRepository.Update(appUser);
                    return RedirectToAction("Index");
                }
                
              

            }
            return View(dto);

        }


        public async Task<IActionResult> SifreUyari()
        {
            IdentityUser ıdentityUser = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == ıdentityUser.Id);

            var appUser1 = _appUserRepository.GetByDefault
                (
                    selector: a => new AppUserUpdateDTO()
                    {
                        ID = a.ID,
                        IdentityId = ıdentityUser.Id,
                        FirstName = a.FirstName,
                        LastName = a.LastName,
                        UserName = a.UserName,
                        Password = a.Password,
                        Mail = ıdentityUser.Email,
                        Image = a.Image,
                        Address = a.Address,
                        WebSite = a.WebSite,
                        GitHub = a.GitHub,
                        Twitter = a.Twitter,
                        Instagram = a.Instagram,
                        Facebook = a.Facebook,
                    },
                    expression: a => a.ID == appUser.ID
                );

            var updateAppUser = _mapper.Map<AppUserUpdateDTO>(appUser);


            return View(updateAppUser);
        }
    }
}
