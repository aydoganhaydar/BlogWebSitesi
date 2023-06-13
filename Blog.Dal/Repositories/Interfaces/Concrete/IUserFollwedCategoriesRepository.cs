using Blog.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Dal.Repositories.Interfaces.Concrete
{
    public interface IUserFollwedCategoriesRepository
    {
        void Create(UserFollwedCategories entity);

        void Delete(UserFollwedCategories entity);
        UserFollwedCategories GetDefault(Expression<Func<UserFollwedCategories, bool>> expression);
    }
}
