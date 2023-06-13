using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Model.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Blog.Model.Entities.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Web.Views.Shared.Components.PopularArticles
{
    [ViewComponent(Name = "PopularArticles")]
    public class PopularArticlesViewComponent:ViewComponent
	{
		private readonly IArticleRepository _articleRepository;

		public PopularArticlesViewComponent(IArticleRepository articleRepository)
		{
			_articleRepository = articleRepository;
		}

		public IViewComponentResult Invoke()
		{
			List<Article> articles = _articleRepository.GetDefaults(a => a.Statu != Statu.Passive && a.Likes.Count()>=2).OrderByDescending(a=>a.Likes.Count()).Take(5).ToList();
			return View(articles);
		}
	}
}
