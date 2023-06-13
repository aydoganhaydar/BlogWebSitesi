using Blog.Model.Entities.Concrete;
using Blog.Model.TypeConfiguration.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Model.TypeConfiguration.Concrete
{
    public class AdminMap:IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(a => a.ID);
            builder.Property(a => a.FirstName).HasMaxLength(20).IsRequired(true);
            builder.Property(a => a.LastName).HasMaxLength(50).IsRequired(true);
        }
    }
}
