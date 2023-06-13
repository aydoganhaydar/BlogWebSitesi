using Blog.Model.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Model.Entities.Enums;
using System;
using Blog.Web.Models.VMs;
using Blog.Dal.Repositories.Concrete;

namespace Blog.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryReporsitory _categoryReporsitory;
        private readonly IAppUserRepository _appUserRepository;
        private readonly IArticleRepository _articleRepository;

        public CategoryController(ICategoryReporsitory categoryReporsitory, IAppUserRepository appUserRepository, IArticleRepository articleRepository)
        {
            _categoryReporsitory = categoryReporsitory;
            _appUserRepository = appUserRepository;
            _articleRepository = articleRepository;
        }
        public IActionResult List()
        {
            var categoryList = _categoryReporsitory.GetDefaults(a => a.Statu != Statu.Passive && a.Onay == Onay.Approved);
            var appUserList = _appUserRepository.GetDefaults(a => a.Statu != Statu.Passive && a.Onay == Onay.Approved);
            var articlesList = _articleRepository.GetDefaults(a => a.Statu != Statu.Passive && a.Onay == Onay.Approved);
            return View(Tuple.Create(categoryList, appUserList, articlesList));
        }

        public IActionResult Detail(int id)
        {
            var category = _categoryReporsitory.GetByDefault
                (
                    selector: a => new CategoryDetailVM()
                    {
                        ID = a.ID,
                        Name = a.Name,
                        Desription = a.Desription,
                        Image = a.Image,
                        CreatedDate = a.CreatedDate,

                    },
                    expression: a => a.Statu != Statu.Passive && a.ID == id
                );
            return View(category);
        }


    }
}
