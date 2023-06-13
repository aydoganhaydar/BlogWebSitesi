using Blog.Model.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Model.Entities.Concrete
{
    public class Admin
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Mail { get; set; }

        public string Password { get; set; }
    }
}
