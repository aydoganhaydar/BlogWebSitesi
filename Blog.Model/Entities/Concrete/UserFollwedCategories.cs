using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Model.Entities.Concrete
{
    public class UserFollwedCategories
    {

        // Ara tablo olduğu için bir kez daha sql tarafından ID verilmesini istemedik.
        public int AppUserID { get; set; }

        public AppUser AppUser { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }
    }
}
