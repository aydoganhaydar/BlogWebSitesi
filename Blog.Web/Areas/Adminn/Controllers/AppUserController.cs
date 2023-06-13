using Blog.Dal.Context;
using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Model.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Web.Areas.Adminn.Controllers
{
    [Area("Adminn")]
    public class AppUserController : Controller
    {
        private readonly IAppUserRepository _appUserRepository;
        private readonly ProjectContext _projectContext;

        public AppUserController(IAppUserRepository appUserRepository,ProjectContext projectContext)
        {
            _appUserRepository = appUserRepository;
            _projectContext = projectContext;
        }

        public IActionResult List()
        {
            List<AppUser> appUsers = _projectContext.AppUsers.ToList();

            return View(appUsers);
        }

        public IActionResult Onay(int id)
        {
            AppUser appUser = _appUserRepository.GetDefault(a => a.ID == id);
            _appUserRepository.Onay(appUser);
            return RedirectToAction("List");

        }

    }
}
