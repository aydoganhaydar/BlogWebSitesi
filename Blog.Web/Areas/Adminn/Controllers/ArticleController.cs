using Blog.Dal.Context;
using Blog.Dal.Repositories.Concrete;
using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Model.Entities.Concrete;
using Blog.Model.Entities.Enums;
using Blog.Web.Areas.Adminn.Models.VMs;
using Blog.Web.Models.VMs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Blog.Web.Areas.Adminn.Controllers
{
    [Area("Adminn")]
    public class ArticleController : Controller
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleController(IArticleRepository articleRepository)
        {
           
            _articleRepository = articleRepository;
        }

        public IActionResult List()
        {
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
                       UserName = a.AppUser.UserName,
                       Onay = a.Onay,
                       Statu = a.Statu,
                   },
                   expression: a => a.Onay == Onay.Approved || a.Onay == Onay.UnApproved,
                   include: a => a.Include(a => a.AppUser)
                ).ToList();
            return View(listem);
        }

        public IActionResult Onayy(int id)
        {
            Article article = _articleRepository.GetDefault(a => a.ID == id);
            _articleRepository.Onay(article);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            Article article = _articleRepository.GetDefault(a => a.ID == id);
            _articleRepository.Delete(article);
            return RedirectToAction("List");
        }

        public IActionResult Detail(int id)
        {
            var article = _articleRepository.GetByDefault
                (
                    selector: a => new ArticleDetaillVM()
                    {
                        ArticleID = a.ID,
                        Title = a.Title,
                        CreatedDate = a.CreatedDate,
                        Image = a.Image,
                        Content = a.Content,
                        CategoryId = a.CategoryID,
                        CategoryName = a.Category.Name,
                        UserId = a.AppUserID,
                        UserImage = a.AppUser.Image,
                        UserFullName = a.AppUser.FullName,
                    },
                    expression: a => a.Statu != Statu.Passive && a.ID == id,
                    include: a => a.Include(a => a.AppUser).Include(a => a.Category)
                );
            return View(article);
        }
    }
}
