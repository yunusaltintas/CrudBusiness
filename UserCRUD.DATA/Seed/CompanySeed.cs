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
    public class CompanySeed : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(new Company { Id = 1, Name = "Romaguera-Crona", CatchPhrase = "Multi-layered client-server neural-net", Bs = "harness real-time e-markets" },
                new Company { Id = 2, Name = "Deckow-Crist", CatchPhrase = "Proactive didactic contingency", Bs = "synergize scalable supply-chains" }
                );
        }
    }
    
}
