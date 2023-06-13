using Blog.Dal.Context;
using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Model.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace Blog.Dal.Repositories.Concrete
{
    public class UserFollwedCategoriesRepository : IUserFollwedCategoriesRepository
    {
        private readonly ProjectContext _context;
        private readonly DbSet<UserFollwedCategories> _table;

        public UserFollwedCategoriesRepository(ProjectContext context)
        {
            _context = context;
            _table = _context.Set<UserFollwedCategories>();
        }
        public void Create(UserFollwedCategories entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(UserFollwedCategories entity)
        {
            // baseentityde n kalıtım almadığı için statu/updatedate gibi propları olmadığı için veritabanından tamamen sildik.
            _table.Remove(entity);
            _context.SaveChanges();
        }

        public UserFollwedCategories GetDefault(Expression<Func<UserFollwedCategories, bool>> expression)
        {
            return _table.Where(expression).FirstOrDefault();
        }
    }
}
