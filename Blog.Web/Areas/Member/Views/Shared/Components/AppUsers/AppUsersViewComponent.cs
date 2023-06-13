using Blog.Dal.Context;
using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Model.Entities.Concrete;
using Blog.Web.Areas.Member.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Web.Areas.Member.Views.Shared.Components.AppUsers
{
    [ViewComponent]
    public class AppUsersViewComponent:ViewComponent
    {
        
        private readonly IAppUserRepository _appUserRepository;

        public AppUsersViewComponent(IAppUserRepository appUserRepository)
        {
            
            _appUserRepository = appUserRepository;
        }
        public IViewComponentResult Invoke(int id)
        {
            GetAppUserDTO appUser = _appUserRepository.GetByDefault
                (
                    selector:a=>new GetAppUserDTO()
                    {
                        ID=a.ID,
                        fullName=a.FullName,
                        Image=a.Image
                    },
                    expression:a=>a.ID==id
                );
            return View(appUser);

        }
    }
}
