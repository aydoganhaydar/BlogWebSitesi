using Blog.Model.Entities.Concrete;
using Blog.Model.TypeConfiguration.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Model.TypeConfiguration.Concrete
{
    public class ArticleMap:BaseMap<Article>
    {
        public override void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasOne(a => a.AppUser).WithMany(a => a.Articles).HasForeignKey(a => a.AppUserID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.Category).WithMany(a => a.Articles).HasForeignKey(a => a.CategoryID).OnDelete(DeleteBehavior.Restrict);

            /*
                DELETEBEHAVİOR (SİLİNME DAVRANIŞI) => Mic.EFCore dan gelen bir enum yapısıdır. İlişkili olduğu entitylerde silinme durumunda nasıl davranıldığını tanımlamaya çalışır.
            * Restrict => ebeveyn - çocuk ilişkisi (parent-child) yani ebeveynsiz çocuk olmayacağı için yani bir category silmeye kalktığınızda makaleler ebeveynsiz kalmış gibi olacağı için sildirmez.
            * NoAction => ilişkili entityler arasındak silinmeyi serbest bırakır. Hiçbir şey yapmaz.
            * 
            * Cascade=>  Ebeveyn -çocuk ilişkisinde ebeveyn silindiğinde ona bağlı tüm çocukları da siler yani bir category silersek o kategoriye ait tüm makaleler silinir. 
            * 
            * SetNull => Default - varsayılan silinme davranışıdır. FK boş geçebilmemize olanak verir. (SQL - nortwindeki product - category gibi)
             
             
             */ 

            base.Configure(builder);
        }
    }
}
