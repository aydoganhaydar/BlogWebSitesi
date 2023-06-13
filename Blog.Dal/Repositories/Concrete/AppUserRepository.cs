using Blog.Dal.Context;
using Blog.Dal.Repositories.Abstract;
using Blog.Dal.Repositories.Interfaces.Abstract;
using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Blog.Dal.Repositories.Concrete
{
    public class AppUserRepository:BaseRepository<AppUser>, IAppUserRepository
    {
        public AppUserRepository(ProjectContext context):base(context)
        {
          
        }


    }
}
