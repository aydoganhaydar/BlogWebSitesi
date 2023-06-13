using Blog.Model.Entities.Concrete;
using Blog.Model.Entities.Enums;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;

namespace Blog.Web.Models.VMs
{
    public class GetArticleWithUsersVM
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public int ArticleID { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Image { get; set; }

        public DateTime CreatedDate { get; set; }

        public List<Like> Likes { get; set; }
        public List<Comment> Comments { get; set; }

        public List<Category> Categories { get; set; }

        public List<AppUser> AppUsers { get; set; }

        public int AppUserID { get; set; }

        public string UserFullName { get; set; }

        public string UserName { get; set; }

        public Statu Statu { get; set; }

        public Onay Onay { get; set; }

    }
}
