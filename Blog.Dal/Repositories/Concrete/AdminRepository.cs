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
    public class AdminRepository<T> : IAdminRepository<T> where T : Admin
    {
        protected readonly ProjectContext _projectContext;
        protected readonly DbSet<T> _table;

        public AdminRepository(ProjectContext projectContext)
        {
            _projectContext = projectContext;
            _table = _projectContext.Set<T>();
        }

        public T GetDefault(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression).FirstOrDefault();
        }
    }
}
