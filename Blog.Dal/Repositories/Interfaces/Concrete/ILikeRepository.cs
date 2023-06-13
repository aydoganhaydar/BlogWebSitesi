using Blog.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Dal.Repositories.Interfaces.Concrete
{
    public interface ILikeRepository
    {
        void Create(Like entity);

        void Delete(Like entity);
        Like GetDefault(Expression<Func<Like, bool>> expression);
    }
}
