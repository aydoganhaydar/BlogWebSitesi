using Blog.Model.Entities.Abstract;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.IdentityModel.JsonWebTokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Dal.Repositories.Interfaces.Abstract
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Create(T entity);

        void Delete(T entity);

        void Update(T entity); 

        bool Any(Expression<Func <T,bool>> expression);

        T GetDefault(Expression<Func <T,bool>> expression); // Tek bir T nesnesi döner.
        
        List<T> GetDefaults(Expression<Func <T,bool>> expression);

        // Tam olarak bir T tipi dönmeyen ama tek bir nesne dönen, seçim işlemi sonucunda bazı propertyleri seçilen(selctor), filtreleme(expression) ve eager loading yaptığımız için başka tabloları da dahil etmemiz(include) gereken bir metot.
        TResult GetByDefault<TResult>(Expression<Func<T, TResult>> selector,
                            Expression<Func<T, bool>> expression,
                            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);

        List<TResult> GetByDefaults<TResult>(Expression<Func<T, TResult>> selector,
                                             Expression<Func<T, bool>> expression,
                                             Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
                                             Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);
        // Seçim, filtreleme, sıralama ve dahil etme parametrelerini alabilen ve çokça TResult tipini dönebilen metottur. Dahil etme ve sıralama zorunlu değil defaultta null geçilebilen parametrelerdir. 
        void Onay(T entity);

    }

}
