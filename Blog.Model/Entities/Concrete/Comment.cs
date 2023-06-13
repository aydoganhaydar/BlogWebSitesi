        using Blog.Model.Entities.Abstract;
using Blog.Model.Entities.Enums;
using System.Collections.Generic;

namespace Blog.Model.Entities.Concrete
{
    public class Comment :BaseEntity
    {
        public string Text { get; set; }

        

        // NAVIGATION PROPERTY

        public int AppUserID { get; set; }

        public AppUser AppUser { get; set; }

        public int ArticleID { get; set; }

        public Article Article { get; set; }

    }
}