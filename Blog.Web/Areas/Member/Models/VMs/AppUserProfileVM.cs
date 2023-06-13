using Blog.Model.Entities.Concrete;
using System.Collections.Generic;
using System;
using System.Reflection;
using Microsoft.AspNetCore.Http;

namespace Blog.Web.Areas.Member.Models.VMs
{
    public class AppUserProfileVM
    {
        public int AppUserID { get; set; }

        public string IdentityID { get; set; }

        public string FirstName { get; set; }

        public string LastName{ get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Mail { get; set; }

        public string Image { get; set; }

        public IFormFile ImagePath { get; set; }

        public string Address { get; set; }

        public string WebSite { get; set; }

        public string GitHub { get; set; }

        public string Twitter { get; set; }

        public string Instagram { get; set; }

        public string Facebook { get; set; }

    }
}
