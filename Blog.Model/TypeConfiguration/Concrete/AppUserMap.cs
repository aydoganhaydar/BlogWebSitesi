using Blog.Model.Entities.Concrete;
using Blog.Model.TypeConfiguration.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Model.TypeConfiguration.Concrete
{
    public class AppUserMap : BaseMap<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            // builder.Property(a => a.FirstName).HasMaxLength(50).HasColumnName("Ad").HasColumnType("nchar").IsRequired(true);

            builder.Property(a => a.FirstName).HasMaxLength(50).IsRequired(true);
            base.Configure(builder);
        }
    }
}
