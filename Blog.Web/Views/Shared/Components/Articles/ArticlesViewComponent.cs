using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Web.Models.VMs;
using Blog.Model.Entities.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Blog.Dal.Repositories.Concrete;
using System;

namespace Blog.Web.Views.Shared.Components.Articles
{
    [ViewComponent(Name ="Articles")]
    public class ArticlesViewComponent:ViewComponent
    {
        // Sürekli en güncel makaleyi card gibi yapılarla hem anasayfa da hemde member area içindeki anasayfada göstermek istiyoruz.

        private readonly IArticleRepository _articleRepository;
        private readonly ICategoryReporsitory _categoryReporsitory;

        public ArticlesViewComponent(IArticleRepository articleRepository, ICategoryReporsitory categoryReporsitory)
        {
            _articleRepository = articleRepository;
            _categoryReporsitory = categoryReporsitory;
        }

        public IViewComponentResult Invoke()
        {
            var categorylist = _categoryReporsitory.GetDefaults(a => a.Statu != Statu.Passive);

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
                       Comments= a.Comments,
                       UserFullName = a.AppUser.FullName,
                       AppUserID = a.AppUserID,
                       CategoryId=a.CategoryID,
                       CategoryName=a.Category.Name,                       
                   },
                   expression: a => a.Statu != Statu.Passive && a.Onay==Onay.Approved,
                   include: a => a.Include(a => a.AppUser),
                   orderBy: a => a.OrderByDescending(a => a.CreatedDate)
                ).Take(10).ToList();
            return View(Tuple.Create(listem,categorylist));
        }
    }
}
