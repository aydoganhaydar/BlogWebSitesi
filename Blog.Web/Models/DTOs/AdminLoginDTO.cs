using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Models.DTOs
{
    public class AdminLoginDTO
    {
        [Required(ErrorMessage = "BU ALAN BOŞ OLAMAZ!!!")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [Required(ErrorMessage = "BU ALAN BOŞ OLAMAZ!!!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
