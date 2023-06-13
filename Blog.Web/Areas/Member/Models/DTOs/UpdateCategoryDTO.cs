using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Web.Areas.Member.Models.DTOs
{
    public class UpdateCategoryDTO
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "BU ALAN BOŞ BIRAKILAMAZ...")]
        [MinLength(3, ErrorMessage = "BU ALAN EN AZ 3 KARAKTER İÇERMELİDİR.")] 
        public string Name { get; set; }

        [Required(ErrorMessage = "BU ALAN BOŞ BIRAKILAMAZ...")]
        [MinLength(10, ErrorMessage = "BU ALAN EN AZ 10 KARAKTER İÇERMELİDİR.")]
        public string Desription { get; set; }

        public string Image { get; set; }

        [Required(ErrorMessage = "FOTOĞRAF YÜKLEMELİSİNİZ...")]
        [NotMapped]
        public IFormFile ImagePath { get; set; }

        public int AppUserID { get; set; }
    }
}
