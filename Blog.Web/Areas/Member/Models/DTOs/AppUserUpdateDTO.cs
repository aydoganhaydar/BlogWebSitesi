using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Web.Areas.Member.Models.DTOs
{
    public class AppUserUpdateDTO
    {
        [Required(ErrorMessage = "BOŞ OLAMAZ!!!")]
        public int ID { get; set; }

        [Required(ErrorMessage = "BOŞ OLAMAZ!!!")]
        public string IdentityId { get; set; }

        [Required(ErrorMessage = "FİRST NAME BOŞ OLAMAZ!!!")]
        [MinLength(3, ErrorMessage = "BAŞLIK BİLGİSİ 3 KARAKTERDEN AZ OLAMAZ")]
        [MaxLength(50, ErrorMessage = "EN FAZLA 50 KARAKTER YAZMALISINIZ!!!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LAST NAME BOŞ OLAMAZ!!!")]
        [MinLength(3, ErrorMessage = "BAŞLIK BİLGİSİ 3 KARAKTERDEN AZ OLAMAZ")]
        [MaxLength(50, ErrorMessage = "EN FAZLA 50 KARAKTER YAZMALISINIZ!!!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "USER NAME BOŞ OLAMAZ!!!")]
        [MinLength(3, ErrorMessage = "BAŞLIK BİLGİSİ 3 KARAKTERDEN AZ OLAMAZ")]
        [MaxLength(50, ErrorMessage = "EN FAZLA 50 KARAKTER YAZMALISINIZ!!!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "PASSWORD BİLGİSİ BOŞ OLAMAZ!!!")]
        [MinLength(3, ErrorMessage = "BAŞLIK BİLGİSİ 3 KARAKTERDEN AZ OLAMAZ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "MAİL BİLGİSİ BOŞ OLAMAZ!!!")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        public string Image { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "FOTOĞRAF BİLGİSİ BOŞ OLAMAZ!!!")]
        public IFormFile ImagePath { get; set; }

        [Required(ErrorMessage = "ADRES BİLGİSİ BOŞ OLAMAZ!!!")]
        [MinLength(10, ErrorMessage = "BAŞLIK BİLGİSİ 10 KARAKTERDEN AZ OLAMAZ")]
        public string Address { get; set; }

        public string WebSite { get; set; }

        public string GitHub { get; set; }

        public string Twitter { get; set; }

        public string Instagram { get; set; }

        public string Facebook { get; set; }
    }
}
