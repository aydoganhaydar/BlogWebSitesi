using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Web.Models.VMs;
using Microsoft.AspNetCore.Mvc;
using Blog.Model.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Blog.Model.Entities.Concrete;
using System.Collections.Generic;
using Blog.Dal.Repositories.Concrete;
using System.Linq;
using System;
using Blog.Web.Areas.Member.Models.DTOs;
using Blog.Web.Areas.Member.Models.VMs;
using AutoMapper;

namespace Blog.Web.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleRepository _articleRepository;
        private readonly ICategoryReporsitory _categoryReporsitory;
        private readonly IMapper _mapper;
        private readonly IAppUserRepository _appUserRepository;

        public ArticleController(IArticleRepository articleRepository, ICategoryReporsitory categoryReporsitory, IMapper mapper, IAppUserRepository appUserRepository)
        {
            _articleRepository = articleRepository;
            _categoryReporsitory = categoryReporsitory;
            _mapper = mapper;
            _appUserRepository = appUserRepository;
        }
        public IActionResult Detail(int id) // id=> makale id
        {
            var article = _articleRepository.GetByDefault
                (
                    selector: a => new ArticleDetailVM()
                    {
                        ArticleId = a.ID,
                        Title = a.Title,
                        Content = a.Content,
                        Image = a.Image,
                        CreatedDate = a.CreatedDate,
                        Likes = a.Likes,
                        Comments = a.Comments,
                        CategoryName = a.Category.Name,
                        UserFullName = a.AppUser.FullName,
                        UserId = a.AppUserID,
                        UserImage = a.AppUser.Image
                    },
                    expression: a => a.Statu != Statu.Passive && a.ID == id,
                    include: a => a.Include(a => a.AppUser).Include(a => a.Category)

                );
            return View(article);
        }

        public IActionResult FullArticles()
        {
            var categoryList = _categoryReporsitory.GetDefaults(a => a.Statu != Statu.Passive && a.Onay == Onay.Approved);
            var appUserList = _appUserRepository.GetDefaults(a => a.Statu != Statu.Passive && a.Onay == Onay.Approved);
            Article article = _articleRepository.GetDefault(a => a.Statu != Statu.Passive && a.Onay == Onay.Approved);
            var filterArticle = _mapper.Map<ArticleFilterDTO>(article);

            filterArticle.Categories = _categoryReporsitory.GetByDefaults
                (
                    selector: a => new GetCategoryDTO { ID = a.ID, Name = a.Name }, expression: a => a.Statu != Statu.Passive
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
            return View(Tuple.Create(listem, filterArticle, categoryList, appUserList));
        }

    }
}
