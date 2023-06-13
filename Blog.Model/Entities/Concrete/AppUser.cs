using Blog.Model.Entities.Abstract;
using Blog.Model.Entities.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Blog.Model.Entities.Concrete
{
    public class AppUser : BaseEntity
    {

        public AppUser()
        {
            Articles = new List<Article>();
            Likes = new List<Like>();
            UserFollwedCategories = new List<UserFollwedCategories>();
            Comments= new List<Comment>();

        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public string Image { get; set; }
        [NotMapped] // Bu property veritabanı tarafına kaydolmayacak.
        public IFormFile ImagePath { get; set; }

        public string IdentityId { get; set; }

        public string Address { get; set; }

        public string WebSite { get; set; }

        public string GitHub { get; set; }

        public string Twitter { get; set; }

        public string Instagram { get; set; }

        public string Facebook { get; set; }



        // NAVIGATION PROPERTY

        public List<Article> Articles { get; set; }

        public List<Like> Likes { get; set; }

        public List<Comment> Comments { get; set; }

        public List<UserFollwedCategories> UserFollwedCategories { get; set; }

        public List<AppUserPasswords> AppUserPasswords { get; set; }
    }
}
