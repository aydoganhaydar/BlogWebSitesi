using Blog.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Dal.Repositories.Interfaces.Concrete
{
    public interface IAdminRepository<T> where T : Admin
    {
        T GetDefault(Expression<Func<T, bool>> expression); // Tek bir admin nesnesi döner.
    }
}
