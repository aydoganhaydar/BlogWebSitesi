using Blog.Model.Entities.Concrete;
using System.Collections.Generic;

namespace Blog.Web.Areas.Member.Models.DTOs
{
    public class GetCategoryDTO
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<UserFollwedCategories> follwedCategories { get; set; }

    }
}
