using Blog.Dal.Repositories.Concrete;
using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Model.Entities.Concrete;
using Blog.Model.Entities.Enums;
using Blog.Web.Areas.Adminn.Models.DTOs;
using Blog.Web.Models.VMs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Web.Areas.Adminn.Controllers
{
    [Area("Adminn")]
    public class CategoryController:Controller
    {
        private readonly ICategoryReporsitory _categoryReporsitory;

        public CategoryController(ICategoryReporsitory categoryReporsitory)
        {
            _categoryReporsitory = categoryReporsitory;
        }
        public IActionResult List()
        {
            List<GetCategoryyDTO> listem = _categoryReporsitory.GetByDefaults
                (
                   selector: a => new GetCategoryyDTO()
                   {
                       ID=a.ID,
                       Name=a.Name,
                       Description=a.Desription,
                       Image=a.Image,
                       Onay=a.Onay,
                       Statu=a.Statu,
                   },
                   expression: a => a.Onay == Onay.Approved || a.Onay == Onay.UnApproved
                ).ToList();
            return View(listem);
        }
        public IActionResult Onayy(int id)
        {
            Category category = _categoryReporsitory.GetDefault(a => a.ID == id);
            _categoryReporsitory.Onay(category);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            Category category = _categoryReporsitory.GetDefault(a => a.ID == id);
            _categoryReporsitory.Delete(category);
            return RedirectToAction("List");
        }
    }
}
