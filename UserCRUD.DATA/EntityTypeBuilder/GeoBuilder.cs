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
    public class GeoBuilder : IEntityTypeConfiguration<Geo>
    {
        public void Configure(EntityTypeBuilder<Geo> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired().UseIdentityColumn(1, 1);

            builder.Property(x => x.Lat).HasMaxLength(250);
            builder.Property(x => x.Lng).HasMaxLength(250);
        }
    }
}
