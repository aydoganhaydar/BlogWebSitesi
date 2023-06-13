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
    public class LikeRepository : ILikeRepository
    {
        private readonly ProjectContext _context;
        private readonly DbSet<Like> _table;

        public LikeRepository(ProjectContext context)
        {
            _context = context;
            _table = _context.Set<Like>();
        }
        public void Create(Like entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Like entity)
        {
            // baseentityde n kalıtım almadığı için statu/updatedate gibi propları olmadığı için veritabanından tamamen sildik.
            _table.Remove(entity); 
            _context.SaveChanges();
        }

        public Like GetDefault(Expression<Func<Like,bool>>expression)
        {
            return _table.Where(expression).FirstOrDefault();
        }
    }
}
