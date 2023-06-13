using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Web.Models.DTOs
{
    public class CreateUserDTO
    {
        [Required(ErrorMessage ="BU ALAN BOŞ BIRAKILAMAZ!!!")]
        [MinLength(3, ErrorMessage ="EN AZ 3 KARAKTER YAZMALISINIZ!!!")]
        [MaxLength(50,ErrorMessage ="EN FAZLA 50 KARAKTER YAZMALISINIZ!!!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "BU ALAN BOŞ BIRAKILAMAZ!!!")]
        [MinLength(3, ErrorMessage = "EN AZ 3 KARAKTER YAZMALISINIZ!!!")]
        [MaxLength(50, ErrorMessage = "EN FAZLA 50 KARAKTER YAZMALISINIZ!!!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "BU ALAN BOŞ BIRAKILAMAZ!!!")]
        [MinLength(3, ErrorMessage = "EN AZ 3 KARAKTER YAZMALISINIZ!!!")]
        [MaxLength(50, ErrorMessage = "EN FAZLA 50 KARAKTER YAZMALISINIZ!!!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "BU ALAN BOŞ BIRAKILAMAZ!!!")]
        [MinLength(3, ErrorMessage = "EN AZ 3 KARAKTER YAZMALISINIZ!!!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        // HATA ANINDA KONUŞALIM...
        public string Image { get; set; }

        [NotMapped]
        [Required(ErrorMessage ="BU ALAN BOŞ BIRAKILAMAZ!!!")]
        public IFormFile ImagePath { get; set; }

        [Required(ErrorMessage ="BU ALAN BOŞ BIRAKILAMAZ!!!")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }




    }
}
