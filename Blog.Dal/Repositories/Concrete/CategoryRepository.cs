using Blog.Dal.Context;
using Blog.Dal.Repositories.Abstract;
using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Model.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Dal.Repositories.Concrete
{
    public class CategoryRepository:BaseRepository<Category>, ICategoryReporsitory
    {
        public CategoryRepository(ProjectContext context):base(context)
        {

        }

        public List<Category> GetCategoriesWithUser(int id)
        {
            return _context.UserFollwedCategories.Include(a=>a.AppUser).Include(a=>a.Category).Where(a=>a.AppUserID==id).Select(a=>a.Category).ToList();
        }




    }
}
