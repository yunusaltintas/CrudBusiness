using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCRUD.DATA.Entities;
using UserCRUD.DATA.EntityTypeBuilder;
using UserCRUD.DATA.Seed;

namespace UserCRUD.DATA
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Geo> Geo { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Address> Address { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new UserBuilder())
                .ApplyConfiguration(new AddressBuilder())
                .ApplyConfiguration(new GeoBuilder())
                .ApplyConfiguration(new CompanyBuilder());

            modelBuilder
                .ApplyConfiguration(new GeoSeed())
                .ApplyConfiguration(new AddressSeed())
                .ApplyConfiguration(new CompanySeed())
                .ApplyConfiguration(new UserSeed());
        }
    }
}
