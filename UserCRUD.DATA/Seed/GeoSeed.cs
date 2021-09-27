using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCRUD.DATA.Entities;

namespace UserCRUD.DATA.Seed
{
    public class GeoSeed : IEntityTypeConfiguration<Geo>
    {
        public void Configure(EntityTypeBuilder<Geo> builder)
        {
            builder.HasData(new Geo { Id = 1, Lat = "-37.3159", Lng = "81.1496" },
                new Geo { Id = 2, Lat = "-43.9509", Lng = "-34.4618" }
                );
        }
    }
}
