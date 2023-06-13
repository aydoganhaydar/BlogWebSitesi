using Blog.Model.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Blog.Web.Models.VMs
{
    public class AppUserDetailVM
    {
        // APPUSER

        public int AppUserID { get; set; }

        public string IdentityID { get; set; }

        public string FullName { get; set; }

        public string Mail { get; set; }

        public string Image { get; set; }

        public string Address { get; set; }

        public string WebSite { get; set; }

        public string GitHub { get; set; }

        public string Twitter { get; set; }

        public string Instagram { get; set; }

        public string Facebook { get; set; }

        public DateTime CreatedDate { get; set; }

        public List<Article> Articles { get; set; }

        public List<Category> Categories { get; set; }

        public List<Like> Likes { get; set; }

        public int CookieID { get; set; }






    }
}
