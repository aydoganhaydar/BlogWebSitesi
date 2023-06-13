using Blog.Model.Entities.Concrete;
using Blog.Model.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Areas.Member.Models.VMs
{
    public class ArticleDetaillVM
    {
        // ARTICLE

        public int ArticleID { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Image { get; set; }

        public  DateTime CreatedDate { get; set; }

        public List<Like> Likes { get; set; }

        public List<Comment> Comments { get; set; }

        // CATEGORY

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        // APPUSER

        public int UserId { get; set; }

        public string UserFullName { get; set; }

        public string UserImage { get; set; }

        public DateTime UserCreatedDate { get; set; }

        public int AppUserID { get; set; }

        public string CookieImage { get; set; }

        public string CookieFullName { get; set; }

        // Yorumlar /// todo : 

        [Required(ErrorMessage ="BU ALAN BOŞ GEÇİLEMEZ...")]
        [MinLength(10,ErrorMessage ="EN AZ 10 KARAKTER GİRİNİZ...")]
        public string Text { get; set; }

        public Onay Onay { get; set; }





    }
}
