using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Model.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blog.Web.Areas.Member.Controllers
{
    [Area("Member")]
    public class HomeController:Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IAppUserRepository _appUserRepository;

        public HomeController(UserManager<IdentityUser> userManager, IAppUserRepository appUserRepository)
        {
            _userManager = userManager;
            _appUserRepository = appUserRepository;
        }
        public async Task<IActionResult> Hakkimizda()
        {
            IdentityUser identityUser = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);

            if (identityUser != null) return View(appUser);
            return Redirect("~/");
        }
    }
}
