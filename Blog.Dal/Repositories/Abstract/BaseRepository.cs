using Blog.Dal.Context;
using Blog.Dal.Repositories.Interfaces.Abstract;
using Blog.Model.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Blog.Model.Entities.Enums;

namespace Blog.Dal.Repositories.Abstract
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly ProjectContext _context;
        protected readonly DbSet<T> _table;

        public BaseRepository(ProjectContext context)
        {
            _context = context;
            _table = _context.Set<T>();   
        }
        public bool Any(Expression<Func<T, bool>> expression)
        {
            return _table.Any(expression);
        }

        public void Create(T entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            entity.DeleteDate= DateTime.Now;
            entity.Statu = Statu.Passive;
            entity.Onay = Model.Entities.Enums.Onay.Approved;
            _context.SaveChanges();
        }

        public TResult GetByDefault<TResult>(Expression<Func<T, TResult>> selector,
                                             Expression<Func<T, bool>> expression, 
                                             Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = _table;
            
            if(include != null) query=include(query); // include parametresi boş değilse ilgili tabloyu da dahil edelim.
            return query.Where(expression).Select(selector).FirstOrDefault();
        }

        public List<TResult> GetByDefaults<TResult>(Expression<Func<T, TResult>> selector, 
                                                    Expression<Func<T, bool>> expression, 
                                                    Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, 
                                                    Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            IQueryable<T> query = _table;

            if (include!=null) query=include(query);
            if (orderBy != null) return orderBy(query).Where(expression).Select(selector).ToList();

            return query.Where(expression).Select(selector).ToList();
        }

        public T GetDefault(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression).FirstOrDefault();
        }

        public List<T> GetDefaults(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression).ToList();
        }

        public void Update(T entity)
        {
            entity.Statu = Statu.Modified;
            entity.UpdateDate = DateTime.Now;
            _table.Update(entity);
            _context.SaveChanges();
        }

        public void Onay(T entity)
        {
            entity.Onay = Model.Entities.Enums.Onay.Approved;
            _table.Update(entity);
            _context.SaveChanges();
        }
    }
}
