using AutoMapper;
using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Model.Entities.Concrete;
using Blog.Web.Models.DTOs;
using Blog.Web.Models.VMs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using Blog.Model.Entities.Enums;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Blog.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IAppUserRepository _appUserRepository;

        public UserController(UserManager<IdentityUser> userManager, IMapper mapper, IAppUserRepository appUserRepository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _appUserRepository = appUserRepository;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserDTO dto)
        {
            if (ModelState.IsValid)
            {
                string newId = Guid.NewGuid().ToString();
                IdentityUser identityUser = new IdentityUser() { Email = dto.Mail, UserName = dto.UserName, Id = newId  };
                IdentityResult result = await _userManager.CreateAsync(identityUser, dto.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(identityUser, "Member");  // kişiye member rolünü eklemiş olduk.

                    var user = _mapper.Map<AppUser>(dto);
                    user.IdentityId = newId;

                    using var image = Image.Load(dto.ImagePath.OpenReadStream());  // fotoğrafı yükleyip okumuş olduk.
                    image.Mutate(a => a.Resize(80, 80)); // mutate : şekillendirmek
                    image.Save($"wwwroot/images/{user.UserName}.jpg");

                    user.Image = $"/images/{user.UserName}.jpg";

                    _appUserRepository.Create(user);
                    return RedirectToAction("Index", "Home");
                }



            }
            return View(dto);
        }

        public async Task<IActionResult> AppUserProfile(AppUserDetailVM vm, int id)
        {
            AppUser appUser1 = _appUserRepository.GetDefault(a => a.ID == id);
            IdentityUser ıdentityUser = await _userManager.FindByIdAsync(appUser1.IdentityId);
            
            var appUser = _appUserRepository.GetByDefault
                (
                    selector: a => new AppUserDetailVM()
                    {
                        AppUserID = a.ID,
                        IdentityID = a.IdentityId,
                        FullName = a.FullName,
                        Mail=ıdentityUser.Email,
                        Image = a.Image,
                        Address = a.Address,
                        WebSite = a.WebSite,
                        GitHub = a.GitHub,
                        Twitter = a.Twitter,
                        Instagram = a.Instagram,
                        Facebook = a.Facebook,
                        Articles = a.Articles,
                        Likes = a.Likes,
                    },
                    expression: a => a.Statu != Statu.Passive && a.ID == id,
                    include: a => a.Include(a => a.Articles).Include(a => a.Likes)

                );
            return View(appUser);
        }


    }
}
