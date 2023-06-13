using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Model.Entities.Concrete;
using Blog.Model.Entities.Enums;
using Blog.Web.Areas.Member.Models.VMs;
using Blog.Web.Areas.Member.Models.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AutoMapper;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Grpc.Core;
using Blog.Web.Models.VMs;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blog.Web.Areas.Member.Controllers
{
    [Area("Member")]
    public class ArticleController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IAppUserRepository _appUserRepository;
        private readonly ICategoryReporsitory _categoryReporsitory;
        private readonly IMapper _mapper;
        private readonly IArticleRepository _articleRepository;
        private readonly ILikeRepository _likeRepository;
        private readonly ICommentRepository _commentRepository;

        public ArticleController(UserManager<IdentityUser> userManager, IAppUserRepository appUserRepository,ICategoryReporsitory categoryReporsitory, IMapper mapper, IArticleRepository articleRepository, ILikeRepository likeRepository, ICommentRepository commentRepository)
        {
            _userManager = userManager;
            _appUserRepository = appUserRepository;
            _categoryReporsitory = categoryReporsitory;
            _mapper = mapper;
            _articleRepository = articleRepository;
            _likeRepository = likeRepository;
            _commentRepository = commentRepository;
        }

        [HttpGet]
        public async Task< IActionResult> Create()
        {
            IdentityUser user = await _userManager.GetUserAsync(User);

            AppUser appUser= _appUserRepository.GetDefault(a=>a.IdentityId==user.Id);

            var Categories = new List<SelectListItem>();

            foreach (var item in _categoryReporsitory.GetDefaults(a=>a.Statu!=Statu.Passive && a.Onay==Onay.Approved))
            {
                Categories.Add(new SelectListItem
                {
                    Text=item.Name,
                    Value=item.ID.ToString(),
                    Selected=false

                });
            }

            ArticleCreateVM vm = new ArticleCreateVM()
            {
                AppUserID = appUser.ID,

                Categories = Categories,

            };
            
            return View(vm);

        }

        [HttpPost]
        public IActionResult Create(ArticleCreateVM vm, string[] Categories)
        {

                if (ModelState.IsValid)
                {
                    var article = _mapper.Map<Article>(vm);

                    using var image = Image.Load(vm.ImagePath.OpenReadStream());// fotoğrafı yükleyip okuduk.
                    image.Mutate(a => a.Resize(80, 80));

                    Guid guid = Guid.NewGuid();

                    image.Save($"wwwroot/images/{guid}.jpeg");

                    article.Image = $"/images/{guid}.jpeg";

                    _articleRepository.Create(article);

                    return RedirectToAction("List");

                }
            var Categoriess = new List<SelectListItem>();

            foreach (var item in _categoryReporsitory.GetDefaults(a => a.Statu != Statu.Passive && a.Onay == Onay.Approved))
            {
                Categoriess.Add(new SelectListItem
                {
                    Text = item.Name,
                    Value = item.ID.ToString()

                });
            }
            vm.Categories = Categoriess;

            return View(vm);

        }

        public async Task<IActionResult> List()  // Kişinin kendi makalelerini göstermek istiyoruz. 
        {
            IdentityUser user = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == user.Id);


            var list = _articleRepository.GetByDefaults
                (
                    selector:a=> new GetArticleVM() 
                    {
                        AppUserID=a.AppUserID,
                        ArticleID=a.ID,
                        CategoryName=a.Category.Name,
                        FullName=a.AppUser.FullName,
                        Title=a.Title,
                        Image=a.Image
                    },
                    expression:a => a.Statu != Statu.Passive && a.AppUserID==appUser.ID, 
                    include:a=>a.Include(a=>a.AppUser).Include(a=>a.Category)
                    
                );
            return View(Tuple.Create(list,appUser));
            // todo: categoryde kullandığımız list şablonunu kullanalım.
        }

        [HttpGet]

        public IActionResult Update(int id)
        {

            Article article = _articleRepository.GetDefault(a => a.ID == id);

            var updateArticle = _mapper.Map<ArticleUpdateVM>(article);

            updateArticle.Categories = _categoryReporsitory.GetByDefaults
                (
                    selector: a => new GetCategoryDTO { ID = a.ID, Name= a.Name }, expression:a=>a.Statu!=Statu.Passive
                );
            return View(updateArticle);

        }
        [HttpPost]

        public IActionResult Update(ArticleUpdateVM vm)
        {
            if (ModelState.IsValid)
            {

                var article = _mapper.Map<Article>(vm);
                System.IO.File.Delete($"wwwroot{article.Image}");
                using var image = Image.Load(vm.ImagePath.OpenReadStream()); // fotoğraf okuyup yükledik.
                image.Mutate(a => a.Resize(80, 80));
                    Guid guid = Guid.NewGuid();
                    image.Save($"wwwroot/images/{guid}.jpeg");
                    article.Image = $"/images/{guid}.jpeg";

                    _articleRepository.Update(article);

                    return RedirectToAction("List");
  
            }
            vm.Categories = _categoryReporsitory.GetByDefaults
                (
                    selector: a => new GetCategoryDTO { ID = a.ID, Name = a.Name },
                    expression: a => a.Statu != Statu.Passive
                );
            return View(vm);

            //todo: negatif seneryoda yani validasyon kurallarına uyulmadığı zaman categories null gelecek ve html foreachte hata yaratacak.

            // todo : makale fotoğrafını güncellenmez ise ?

            // todo : makale fotoğrafı güncellenirse, eski makale fotoğrafını silelim ki proje şişmesin.
        }

        public IActionResult Delete(int id)
        {
            Article article = _articleRepository.GetDefault(a => a.ID == id);
            _articleRepository.Delete(article);
            return RedirectToAction("List");
        }

        public async Task< IActionResult> Detail(int id) 
        {

            IdentityUser user = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == user.Id);
            Comment comment = new Comment();
          

            var article = _articleRepository.GetByDefault
                (
                    selector: a=>new ArticleDetaillVM() 
                    {
                        ArticleID=a.ID,
                        Title=a.Title,
                        CreatedDate=a.CreatedDate,
                        Image=a.Image,
                        Content=a.Content,
                        Likes=a.Likes,
                        Comments=a.Comments,
                        CategoryId=a.CategoryID,
                        CategoryName=a.Category.Name,
                        UserCreatedDate=a.AppUser.CreatedDate,
                        UserId=a.AppUserID,
                        UserImage=a.AppUser.Image,
                        UserFullName=a.AppUser.FullName,
                        AppUserID=appUser.ID,
                        CookieImage=appUser.Image,
                        CookieFullName=appUser.FullName,
                        Text=comment.Text,
                        Onay=comment.Onay,
                    },
                    expression:a=>a.Statu!= Statu.Passive && a.ID==id,
                    include:a=>a.Include(a=>a.AppUser).Include(a=>a.Category)
                );
            return View(article);
        }

        public async Task<IActionResult> Like(int id)
        {
            Article article = _articleRepository.GetDefault(a => a.ID == id);
            IdentityUser user = await _userManager.GetUserAsync(User);

            AppUser appUser=_appUserRepository.GetDefault(a=>a.IdentityId==user.Id);

            Like like=new Like() { AppUser = appUser, AppUserID=appUser.ID,Article=article, ArticleID=id };

            _likeRepository.Create(like);

            return RedirectToAction("Detail",new {id = id});
        }

        public async Task<IActionResult> UnLike(int id)
        {
            Article article = _articleRepository.GetDefault(a => a.ID == id);
            IdentityUser user = await _userManager.GetUserAsync(User);

            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == user.Id);

            Like like = _likeRepository.GetDefault(a => a.ArticleID == id && a.AppUserID == appUser.ID);

            _likeRepository.Delete(like);

            return RedirectToAction("Detail", new { id = id });
        }

        [HttpPost]
        public async Task< IActionResult> CreateComment(ArticleDetaillVM vm, int id)
        {
            Article article = _articleRepository.GetDefault(a => a.ID == id);
            IdentityUser user = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == user.Id);
            Comment comment1 = new Comment() { Text = vm.Text, AppUser =appUser, AppUserID=vm.AppUserID, Article=article, ArticleID=vm.ArticleID};

            if (ModelState.IsValid)
            {
                var comment = _mapper.Map<Comment>(comment1);
                _commentRepository.Create(comment);
                return RedirectToAction("Detail", new { id = id });
            }

            
            return View(vm);
        }

        public async Task<IActionResult> FullArticles()
        {
            IdentityUser identityUser = await _userManager.GetUserAsync(User);
            AppUser appUser = _appUserRepository.GetDefault(a => a.IdentityId == identityUser.Id);

            if (identityUser != null)
            { 
                var categoryList = _categoryReporsitory.GetDefaults(a => a.Statu != Statu.Passive && a.Onay == Onay.Approved);
            var appUserList = _appUserRepository.GetDefaults(a => a.Statu != Statu.Passive && a.Onay == Onay.Approved);
            Article article = _articleRepository.GetDefault(a => a.Statu != Statu.Passive && a.Onay == Onay.Approved);
            var filterArticle = _mapper.Map<ArticleFilterDTO>(article);

            filterArticle.Categories = _categoryReporsitory.GetByDefaults
                (
                    selector: a => new GetCategoryDTO { ID = a.ID, Name = a.Name }, expression: a => a.Statu != Statu.Passive
                );

            List<GetArticleWithUsersVM> listem = _articleRepository.GetByDefaults
                (
                   selector: a => new GetArticleWithUsersVM()
                   {
                       Title = a.Title,
                       Content = a.Content,
                       CreatedDate = a.CreatedDate,
                       ArticleID = a.ID,
                       Image = a.Image,
                       Likes = a.Likes,
                       Comments = a.Comments,
                       UserFullName = a.AppUser.FullName,
                       AppUserID = a.AppUserID,
                       CategoryId = a.CategoryID,
                       CategoryName = a.Category.Name,
                   },
                   expression: a => a.Statu != Statu.Passive && a.Onay == Onay.Approved,
                   include: a => a.Include(a => a.AppUser).Include(b => b.Category),
                   orderBy: a => a.OrderByDescending(a => a.CreatedDate)
                ).ToList();
            return View(Tuple.Create(listem, filterArticle, categoryList, appUserList,appUser));
        }

            else
            {
                return Redirect("~/"); // RedirectToAction ("Index", "Home");
            }
        }




    }
}
