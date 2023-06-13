using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Model.Entities.Enums;
using Blog.Web.Models.VMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Web.Views.Shared.Components.CategoryArticles
{
    [ViewComponent(Name = "CategoryArticles")]
    public class CategoryArticlesViewComponent:ViewComponent
    {
        private readonly IArticleRepository _articleRepository;

        public CategoryArticlesViewComponent(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public IViewComponentResult Invoke(int id)
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
                       CategoryName = a.Category.Name

                   },
                   expression: a => a.Statu != Statu.Passive && a.Onay == Onay.Approved && a.CategoryID == id,
                   include: a => a.Include(a => a.Category),
                   orderBy: a => a.OrderByDescending(a => a.CreatedDate)
                ).Take(5).ToList();
            return View(listem);
        }
    }
}
