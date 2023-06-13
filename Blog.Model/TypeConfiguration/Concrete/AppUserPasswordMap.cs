using Blog.Model.Entities.Concrete;
using Blog.Model.TypeConfiguration.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Model.TypeConfiguration.Concrete
{
    public class AppUserPasswordMap:IEntityTypeConfiguration<AppUserPasswords>
    {
        public void Configure(EntityTypeBuilder<AppUserPasswords> builder)
        {
            builder.Property(a => a.CreatedDate).IsRequired(true);

            builder.HasKey(a => new { a.ID}); // primarykey 

            builder.HasOne(a => a.AppUser).WithMany(a => a.AppUserPasswords).HasForeignKey(a => a.AppUserID);
        }
    }
}
