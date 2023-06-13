using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Web.Areas.Member.Models.DTOs
{
    public class CreateCategoryDTO
    {
        public int AppUserID { get; set; }

        [Required (ErrorMessage ="BU ALAN BOŞ BIRAKILAMAZ...")]
        [MinLength(3,ErrorMessage ="BU ALAN EN AZ 3 KARAKTER İÇERMELİDİR.")]
        public string Name { get; set; }


        [Required(ErrorMessage = "BU ALAN BOŞ BIRAKILAMAZ...")]
        [MinLength(10, ErrorMessage = "BU ALAN EN AZ 10 KARAKTER İÇERMELİDİR.")]
        public string Desription { get; set; }

        public string Image { get; set; }


        [NotMapped]
        [Required(ErrorMessage = "FOTOĞRAF YÜKLEMELİSİNİZ!!!")]
        public IFormFile ImagePath { get; set; }
    }
}
