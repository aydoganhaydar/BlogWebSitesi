using Blog.Model.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Blog.Web.Models.VMs
{
    public class ArticleDetailVM
    {
        // ARTICLE

        public string Title  { get; set; }

        public string Content { get; set; }

        public string Image { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ArticleId { get; set; }

        public List<Like> Likes { get; set; }

        public List<Comment> Comments { get; set; }

        // CATEGORY

        public string CategoryName { get; set; }

        // APPUSER

        public int UserId { get; set; }

        public string UserFullName { get; set; }

        public string UserImage { get; set; }






    }
}
