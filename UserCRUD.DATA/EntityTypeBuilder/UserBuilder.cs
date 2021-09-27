using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCRUD.DATA.Entities;

namespace UserCRUD.DATA.EntityTypeBuilder
{
    public class UserBuilder : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired().UseIdentityColumn(1, 1);

            builder.Property(x => x.Email).HasMaxLength(250);
            builder.Property(x => x.Phone).HasMaxLength(250);
            builder.Property(x => x.Name).HasMaxLength(250);
            builder.Property(x => x.Username).HasMaxLength(250);
            builder.Property(x => x.Website).HasMaxLength(250);
        }
    }
}


