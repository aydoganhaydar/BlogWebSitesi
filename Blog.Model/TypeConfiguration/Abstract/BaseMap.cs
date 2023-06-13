using Blog.Model.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Model.TypeConfiguration.Abstract
{
    public abstract class BaseMap<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {

        // Bu sınıf diğer sınıflara kalıtım vereceği için CONFIGURE metodu diğer sınıflarda istediği gibi doldurulabilsin ekleyebilsin diye metodu VIRTUAL olarak işaretledik.
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(a => a.ID);
            builder.Property(a => a.CreatedDate).IsRequired(true);
            builder.Property(a => a.UpdateDate).IsRequired(false);
            builder.Property(a => a.DeleteDate).IsRequired(false);

        }
    }
}
