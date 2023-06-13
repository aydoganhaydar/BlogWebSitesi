using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Model.Entities.Concrete
{
    public class AppUserPasswords
    {
        public int ID { get; set; }
        public int AppUserID { get; set; }

        public AppUser AppUser { get; set; }

        public string Password { get; set; }

        private DateTime _createdDate = DateTime.Now;

        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }



    }
}
