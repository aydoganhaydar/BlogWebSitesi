using Blog.Model.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Model.TypeConfiguration.Concrete
{
    public class UserFollwedCategoryMap : IEntityTypeConfiguration<UserFollwedCategories>
    {
        public void Configure(EntityTypeBuilder<UserFollwedCategories> builder)
        {
            builder.HasKey(a => new { a.AppUserID, a.CategoryID }); // primarykey 
            builder.HasOne(a => a.AppUser).WithMany(a => a.UserFollwedCategories).HasForeignKey(a => a.AppUserID); // ilişki oluşturmak ve foreignkey tanılamak için kullanılan kod bloğu
            builder.HasOne(a => a.Category).WithMany(a => a.UserFollwedCategories).HasForeignKey(a => a.CategoryID);
        }
    }
}
