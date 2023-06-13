using Blog.Web.Areas.Member.Models.DTOs;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace Blog.Web.Areas.Member.Models.VMs
{
    public class ArticleUpdateVM
    {
        // ARTICLE

        public int ID { get; set; }

        [Required(ErrorMessage ="BAŞLIK BİLGİSİ BOŞ OLAMAZ!!!")]
        [MinLength(3,ErrorMessage ="BAŞLIK BİLGİSİ 3 KARAKTERDEN AZ OLAMAZ")]
        public string Title { get; set; }

        [Required(ErrorMessage = "İÇERİK BİLGİSİ BOŞ OLAMAZ!!!")]
        [MinLength(30, ErrorMessage = "İÇERİK BİLGİSİ 30 KARAKTERDEN AZ OLAMAZ")]
        public string Content { get; set; }

        public string Image { get; set; }

        [Required(ErrorMessage = "FOTOĞRAF YÜKLEMELİSİNİZ...")]
        [NotMapped]
        public IFormFile ImagePath { get; set; }

        // CATEGORY

        [Required(ErrorMessage = " KATEGORİ BİLGİSİ BOŞ OLAMAZ!!!")]
        public int CategoryId { get; set; } // bir kategori seçilmiş olmalı bu yüzden bu alan required olmalı.

        public List< GetCategoryDTO> Categories { get; set; } // amaç : categoryleri viewa taşımak, posta gelmeleri gerekmiyor o yüzden required değiller.


        // APPUSER

        public int AppUserID { get; set; }



    }
}
