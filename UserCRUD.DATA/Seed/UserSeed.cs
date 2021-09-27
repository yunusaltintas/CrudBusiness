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
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { Id = 1, Name = "Leanne Graham", Username = "Bret", Email = "Sincere@april.biz", AddressId = 1, Phone = "1-770-736-8031 x56442", Website = "hildegard.org", CompanyId = 1 },
                new User { Id = 2, Name = "Ervin Howell", Username = "Antonette", Email = "Shanna@melissa.tv", AddressId = 2, Phone = "010-692-6593 x09125", Website = "anastasia.net", CompanyId = 2 }
                );
        }
    }
}
