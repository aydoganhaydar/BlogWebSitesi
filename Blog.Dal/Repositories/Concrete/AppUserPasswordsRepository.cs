using Blog.Dal.Context;
using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Model.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Dal.Repositories.Concrete
{
    public class AppUserPasswordsRepository : IAppUserPasswordsRepository
    {
        private readonly ProjectContext _context;
        private readonly DbSet<AppUserPasswords> _table;

        public AppUserPasswordsRepository(ProjectContext context)
        {
            _context = context;
            _table = _context.Set<AppUserPasswords>();

        }
        
        public void Create(AppUserPasswords entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(AppUserPasswords entity)
        {
            _table.Remove(entity);
            _context.SaveChanges();
        }

        public AppUserPasswords GetDefault(Expression<Func<AppUserPasswords, bool>> expression)
        {
            return _table.Where(expression).FirstOrDefault();
        }

        public List<AppUserPasswords> GetDefaults(Expression<Func<AppUserPasswords, bool>> expression)
        {
            return _table.Where(expression).ToList();
        }
    }
}
