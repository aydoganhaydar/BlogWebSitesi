using Blog.Dal.Repositories.Concrete;
using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Model.Entities.Concrete;
using Blog.Model.Entities.Enums;
using Blog.Web.Areas.Adminn.Models.VMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Blog.Web.Areas.Adminn.Controllers
{
    [Area("Adminn")]
    public class CommentController : Controller
    {
        private readonly ICommentRepository _commentRepository;

        public CommentController(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public IActionResult List()
        {
            List<GetCommentVM> comments = _commentRepository.GetByDefaults
                (
                    selector: a => new GetCommentVM()
                    {
                        CommentID = a.ID,
                        Text = a.Text,
                        CreatedDate = a.CreatedDate,
                        Onay = a.Onay,
                        Statu = a.Statu,
                        AppUserID = a.AppUserID,
                        AppUserFullName = a.AppUser.FullName,
                        AppUserImage = a.AppUser.Image,
                        ArticleID = a.ArticleID,
                        ArticleTitle = a.Article.Title,
                    },
                    expression: a => a.Onay == Onay.Approved || a.Onay == Onay.UnApproved,
                    include: a => a.Include(a => a.AppUser).Include(a => a.Article)
                ).ToList();
            return View(comments);
        }

        public IActionResult Onayy(int id)
        {
            Comment comment = _commentRepository.GetDefault(a => a.ID == id);
            _commentRepository.Onay(comment);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            Comment comment = _commentRepository.GetDefault(a => a.ID == id);
            _commentRepository.Delete(comment);
            return RedirectToAction("List");
        }

        public IActionResult Detail(int id)
        {
            var comment = _commentRepository.GetByDefault
                (
                    selector: a=> new GetCommentVM()
                    {
                        CommentID = a.ID,
                        Text = a.Text,
                        CreatedDate = a.CreatedDate,
                        Onay = a.Onay,
                        Statu = a.Statu,
                        AppUserID = a.AppUserID,
                        AppUserFullName = a.AppUser.FullName,
                        AppUserImage = a.AppUser.Image,
                        ArticleID = a.ArticleID,
                        ArticleTitle = a.Article.Title,
                    },
                    expression: a=>a.ID==id
                );
            return View(comment);
            
        }

    }
}
