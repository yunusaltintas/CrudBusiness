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
    public class AddressSeed : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasData(new Address { Id = 1, Street = "Kulas Light", Suite = "Apt. 556", City= "Gwenborough", Zipcode= "92998-3874", GeoID=1 },
                new Address { Id = 2, Street = "Victor Plains", Suite = "Suite 879", City = "Wisokyburgh", Zipcode = "90566-7771", GeoID = 2 }
                );
        }
    }
}
