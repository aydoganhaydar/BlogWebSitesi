using Blog.Model.Entities.Concrete;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Blog.Web.Areas.Member.Models.VMs
{
    public class GetCommentsVM
    {
        // Comment
        public int CommentID { get; set; }

        public string Text { get; set; }

        public DateTime CreatedDate { get; set; }


        // AppUser
        public int AppUserID { get; set; }

        public string AppUserFullName { get; set; }

        public string AppUserImage { get; set; }


        // Article
        public int ArticleID { get; set; }


        



    }
}
