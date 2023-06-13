using Blog.Model.Entities.Abstract;
using Blog.Model.Entities.Enums;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Model.Entities.Concrete
{
    public class Category :BaseEntity
    {
        public Category()
        {

           Articles=new List<Article>();
           UserFollwedCategories = new List<UserFollwedCategories>();
        }

        public string Name { get; set; }

        public string Desription { get; set; }

        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImagePath { get; set; }




        // NAVIGATION PROPERTY

        public List<Article> Articles { get; set; }
        public List<UserFollwedCategories> UserFollwedCategories { get; set; }
        public List<ArticleCategory> ArticleCategories { get; set; }
    }
}