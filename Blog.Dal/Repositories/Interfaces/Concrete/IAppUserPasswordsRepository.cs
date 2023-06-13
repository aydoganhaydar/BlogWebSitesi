using Blog.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Dal.Repositories.Interfaces.Concrete
{
    public interface IAppUserPasswordsRepository
    {
        void Create(AppUserPasswords entity);

        void Delete(AppUserPasswords entity);

        AppUserPasswords GetDefault(Expression<Func<AppUserPasswords, bool>> expression);

        List<AppUserPasswords> GetDefaults(Expression<Func<AppUserPasswords, bool>> expression);
    }
}
