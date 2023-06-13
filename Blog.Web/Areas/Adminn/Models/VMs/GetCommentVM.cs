using Blog.Model.Entities.Enums;
using System;

namespace Blog.Web.Areas.Adminn.Models.VMs
{
    public class GetCommentVM
    {
        public int CommentID { get; set; }

        public string Text { get; set; }

        public DateTime CreatedDate { get; set; }

        public Onay Onay { get; set; }

        public Statu Statu { get; set; }


        // AppUser
        public int AppUserID { get; set; }

        public string AppUserFullName { get; set; }

        public string AppUserImage { get; set; }


        // Article
        public int ArticleID { get; set; }

        public string ArticleTitle { get; set; } 
    }
}
