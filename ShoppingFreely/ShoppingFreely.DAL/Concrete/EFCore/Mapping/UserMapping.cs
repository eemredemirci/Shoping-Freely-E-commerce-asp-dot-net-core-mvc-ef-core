using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingFreely.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingFreely.DAL.Concrete.EFCore.Mapping
{
    internal class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(a => a.Name).HasMaxLength(50);
            builder.HasData(new User() { Id = 0, MailAddress = "admin@admin.com", Password = "123" });
        }
    }
}
