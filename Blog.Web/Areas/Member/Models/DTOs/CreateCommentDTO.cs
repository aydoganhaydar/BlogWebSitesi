using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Areas.Member.Models.DTOs
{
    public class CreateCommentDTO
    {
        [Required(ErrorMessage ="BU ALAN BOŞ BIRAKILAMAZ...")]
        public string Text { get; set; }

        [Required(ErrorMessage = "BU ALAN BOŞ BIRAKILAMAZ...")]
        public int AppUserID { get; set; }

        [Required(ErrorMessage = "BU ALAN BOŞ BIRAKILAMAZ...")]
        public int ArticleID { get; set; }
    }
}
