using Blog.Model.Entities.Concrete;
using Blog.Model.Entities.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Blog.Web.Areas.Adminn.Models.VMs
{
    public class ArticleDetaillVM
    {
        // ARTICLE

        public int ArticleID { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Image { get; set; }

        public DateTime CreatedDate { get; set; }


        // CATEGORY

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        // APPUSER

        public int UserId { get; set; }

        public string UserFullName { get; set; }

        public string UserImage { get; set; }

        public Onay Onay { get; set; }
    }
}
