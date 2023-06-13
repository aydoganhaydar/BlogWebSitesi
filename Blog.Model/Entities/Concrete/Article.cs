using Blog.Model.Entities.Abstract;
using Blog.Model.Entities.Enums;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Model.Entities.Concrete
{
    public class Article :BaseEntity
    {

        public Article()
        {
            Likes = new List<Like>();
            Comments=new List<Comment>();
        }


        public string Title { get; set; }

        public string Content { get; set; }

        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImagePath { get; set; }

        

        // NAVIGATION PROPERTY

        public List<Like> Likes { get; set; }

        public List<Comment> Comments { get; set; }

        public int AppUserID { get; set; }

        public AppUser AppUser { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }

        public List<ArticleCategory> ArticleCategories { get; set; }







    }
}