using Blog.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Dal.Repositories.Interfaces.Concrete
{
    public interface IArticleCategoryRepository
    {
        void Create(ArticleCategory entity);

        void Delete(ArticleCategory entity);
        ArticleCategory GetDefault(Expression<Func<ArticleCategory, bool>> expression);
    }
}
