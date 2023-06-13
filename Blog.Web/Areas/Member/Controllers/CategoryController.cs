using AutoMapper;
using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Model.Entities.Concrete;
using Blog.Web.Areas.Member.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Blog.Model.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using Microsoft.EntityFrameworkCore;
using Blog.Web.Models.VMs;
using System.Collections.Generic;

namespace Blog.Web.Areas.Member.Controllers
{
    [Area("Member")]
    public class CategoryController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICategoryReporsitory _categoryReporsitory;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IAppUserRepository _appUserRepository;
        private readonly IUserFollwedCategoriesRepository _userFollwedCategoriesRepository;

        public CategoryController(IMapper mapper, ICategoryReporsitory categoryReporsitory, UserManager<IdentityUser> userManager, IAppUserRepository appUserRepository, IUserFollwedCategoriesRepository userFollwedCategoriesRepository)
        {
            _mapper = mapper;
            _categoryReporsitory = categoryReporsitory;
            _userManager = userManager;
            _appUserRepository = appUserRepository;
            _userFollwedCategoriesRepository = userFollwedCategoriesRepository;
        }
        [HttpGet]

        public async Task<IActionResult> Create()
        {
            IdentityUser user = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == user.Id);

            CreateCategoryDTO dTO = new CreateCategoryDTO() { AppUserID = appUser.ID };

            return View(dTO);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryDTO dto)
        {
            IdentityUser user = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == user.Id);
            if (ModelState.IsValid)
            {
                var category = _mapper.Map<Category>(dto);
                using var image = Image.Load(dto.ImagePath.OpenReadStream());// fotoğrafı yükleyip okuduk.
                image.Mutate(a => a.Resize(80, 80));


                image.Save($"wwwroot/images/{category.Name}.jpeg");

                category.Image = $"/images/{category.Name}.jpeg";
                _categoryReporsitory.Create(category);
                return RedirectToAction("List");

            }
            return View(dto);

        }

        public async Task<IActionResult> List()
        {
            IdentityUser user = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == user.Id);
            var list = _categoryReporsitory.GetByDefaults
                (
                    selector: a => new GetCategoryDTO()
                    {
                        ID = a.ID,
                        Name = a.Name,
                        Description = a.Desription,
                        follwedCategories = a.UserFollwedCategories
                    },
                    expression: a => a.Statu != Statu.Passive && a.Onay==Onay.Approved
                );
            return View(Tuple.Create(list, appUser));
        }

        [HttpGet]

        public IActionResult Update(int id)
        {
  
            Category category = _categoryReporsitory.GetDefault(a => a.ID == id);
            var updatedCategory = _mapper.Map<UpdateCategoryDTO>(category);
            return View(updatedCategory);
        }

        [HttpPost]

        public IActionResult Update(UpdateCategoryDTO dto)
        {
            if (ModelState.IsValid)
            {
                var updatedCategory = _mapper.Map<Category>(dto);
                System.IO.File.Delete($"wwwroot{updatedCategory.Image}");
                using var image = Image.Load(dto.ImagePath.OpenReadStream());// fotoğrafı yükleyip okuduk.
                image.Mutate(a => a.Resize(80, 80));


                image.Save($"wwwroot/images/{updatedCategory.Name}.jpeg");

                updatedCategory.Image = $"/images/{updatedCategory.Name}.jpeg";
                _categoryReporsitory.Update(updatedCategory);
                return RedirectToAction("List");
            }
            return View(dto);
        }

        public IActionResult Delete(int id)
        {
            Category category = _categoryReporsitory.GetDefault(a => a.ID == id);
            _categoryReporsitory.Delete(category);
            return RedirectToAction("List");

        }

        public async Task<IActionResult> Follow(int id) // gelen id categoryId
        {
            Category category = _categoryReporsitory.GetDefault(a => a.ID == id);

            IdentityUser identityUser = await _userManager.GetUserAsync(User);

            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);

            category.UserFollwedCategories.Add
                (
                    new UserFollwedCategories { AppUser = appUser, AppUserID = appUser.ID, Category = category, CategoryID = category.ID }
                );
            //todo : kullanıcı takip ediyorsa tekrar List sayfasına döndüğünde o kategori için takibi bırak, takip etmedikleri için ise takip et yazmalı ki, daha kullanıcı dostu bir deneyim olsun ve çakışan anahtarları ekleme hatasını almaktan kurtulalım çünkü ara tabloda her satır eşsizdir. Yani aynı satırı tekrar ekleyemezsiniz.
            _categoryReporsitory.Update(category);
            return RedirectToAction("List");
        }

        public async Task<IActionResult> UnFollow(int id)
        {
            Category category = _categoryReporsitory.GetDefault(a => a.ID == id);

            IdentityUser identityUser = await _userManager.GetUserAsync(User);

            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);

            UserFollwedCategories userFollwedCategories = _userFollwedCategoriesRepository.GetDefault(a => a.CategoryID == id && a.AppUserID == appUser.ID);

           _userFollwedCategoriesRepository.Delete(userFollwedCategories);

            return RedirectToAction("List");
        }

        public async Task<IActionResult> Detail(int id)
        {
            IdentityUser identityUser = await _userManager.GetUserAsync(User);

            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);
            var category = _categoryReporsitory.GetByDefault
                (
                    selector: a => new CategoryDetailVM()
                    {
                        ID = a.ID,
                        Name = a.Name,
                        Desription = a.Desription,
                        Image = a.Image,
                        CreatedDate = a.CreatedDate,
                        CookieID = appUser.ID,

                    },
                    expression: a => a.Statu != Statu.Passive && a.ID == id
                );
            return View(category);
        }
    }
}
