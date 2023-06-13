using Blog.Model.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Models.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage ="BU ALAN BOŞ OLAMAZ!!!")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [Required(ErrorMessage = "BU ALAN BOŞ OLAMAZ!!!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public Onay Onay { get; set; }

        public int ID { get; set; }
    }
}
