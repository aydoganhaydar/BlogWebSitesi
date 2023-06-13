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
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly ProjectContext _projectContext;
        private readonly DbSet<ArticleCategory> _table;

        public ArticleCategoryRepository(ProjectContext projectContext)
        {
            _projectContext = projectContext;
            _table = _projectContext.Set<ArticleCategory>();
        }

        public void Create(ArticleCategory entity)
        {
            _table.Add(entity);
            _projectContext.SaveChanges();
        }

        public void Delete(ArticleCategory entity)
        {
            _table.Remove(entity);
            _projectContext.SaveChanges();
        }

        public ArticleCategory GetDefault(Expression<Func<ArticleCategory, bool>> expression)
        {
            return _table.Where(expression).FirstOrDefault();
        }
    }
}
