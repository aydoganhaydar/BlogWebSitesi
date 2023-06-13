using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Areas.Member.Models.DTOs
{
    public class ArticleFilterDTO
    {
        [Required(ErrorMessage = " KATEGORİ BİLGİSİ BOŞ OLAMAZ!!!")]
        public int CategoryId { get; set; } // bir kategori seçilmiş olmalı bu yüzden bu alan required olmalı.

        public List<GetCategoryDTO> Categories { get; set; } // amaç : categoryleri viewa taşımak, posta gelmeleri gerekmiyor o yüzden required değiller.

    }
}
