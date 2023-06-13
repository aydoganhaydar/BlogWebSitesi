using Blog.Dal.Repositories.Interfaces.Concrete;
using Blog.Web.Areas.Member.Models.VMs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Blog.Model.Entities.Enums;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Areas.Member.Views.Shared.Components.Comments
{
    [ViewComponent(Name = "Comments")]
    public class CommentsViewComponent:ViewComponent
    {
        private readonly ICommentRepository _commentRepository;

        public CommentsViewComponent(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public IViewComponentResult Invoke(int id)
        {
            List<GetCommentsVM> getComments = _commentRepository.GetByDefaults
                (
                    selector: a=> new GetCommentsVM()
                    {
                        AppUserID=a.AppUserID,
                        AppUserFullName=a.AppUser.FullName,
                        AppUserImage=a.AppUser.Image,
                        ArticleID=a.ArticleID,
                        CommentID=a.ID,
                        Text=a.Text,
                        CreatedDate=a.CreatedDate

                    },
                    expression:a=>a.Statu!=Statu.Passive && (a.Onay == Onay.Approved && a.ArticleID==id),
                    include: a => a.Include(a => a.AppUser).Include(a => a.Article)
                );
            return View(getComments);
        }
    }
}
