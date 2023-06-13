using Blog.Web.Areas.Member.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Web.Areas.Member.Models.VMs
{
    public class ArticleCreateVM
    {
        // ARTICLE

        [Required(ErrorMessage ="BU ALAN BOŞ BIRAKILAMAZ...")]
        [MinLength(2,ErrorMessage ="EN AZ 2 KARAKTER YAZMALISINIZ...")]
        public string Title { get; set; }

        [Required(ErrorMessage = "BU ALAN BOŞ BIRAKILAMAZ...")]
        [MinLength(80, ErrorMessage = "EN AZ 200 KARAKTER YAZMALISINIZ...")]
        public string Content { get; set; }

        // Bu alan boş olabilir. Çünkü önemli olan ıformfile ın veri çekebilmesi sonrasında kayıt için burayı kullanacağız.
        public string Image  { get; set; }

        [NotMapped]
        [Required(ErrorMessage ="FOTOĞRAF YÜKLEMELİSİNİZ!!!")]
        public IFormFile ImagePath { get; set; }

        // CATEGORY
        [Required(ErrorMessage = "KATEGORİ SEÇİMİ YAPMALISINIZ...")]
        public List<string> CategoryID { get; set; }

        
        public List<SelectListItem> Categories { get; set; } // Her bir kategorinin tüm proplarını taşımaktansa sadece name ve Id taşımak için 

        // APPUSER

        [Required(ErrorMessage = "BU ALAN BOŞ BIRAKILAMAZ...")]
        public int AppUserID { get; set; }







    }
}
