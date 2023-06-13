using Blog.Dal.Repositories.Interfaces.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Member.Views.Shared.Components.UserFollowCategory
{
    [ViewComponent(Name ="UserFollowCategory")]
    public class UserFollowCategoryViewComponent:ViewComponent
    {
        private readonly ICategoryReporsitory _categoryReporsitory;

        /// Şuan cookide olan kullanıcının takip ettiği kategorileri gösterelim.

        public UserFollowCategoryViewComponent(ICategoryReporsitory categoryReporsitory)
        {
            _categoryReporsitory = categoryReporsitory;
        }

        public IViewComponentResult Invoke(int id) // id => appuser id
        {
            var list = _categoryReporsitory.GetCategoriesWithUser(id);return View(list);
        }




    }
}
