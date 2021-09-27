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
    public class AddressBuilder : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired().UseIdentityColumn(1, 1);

            builder.Property(x => x.City).HasMaxLength(250);
            builder.Property(x => x.Street).HasMaxLength(250);
            builder.Property(x => x.Suite).HasMaxLength(250);
            builder.Property(x => x.Zipcode).HasMaxLength(250);

        }
    }
}
