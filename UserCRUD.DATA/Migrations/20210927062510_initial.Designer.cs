﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserCRUD.DATA;

namespace UserCRUD.DATA.Migrations
{
    [DbContext(typeof(UserDbContext))]
    [Migration("20210927062510_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UserCRUD.DATA.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("GeoID")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Suite")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Zipcode")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("GeoID");

                    b.ToTable("Address");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Gwenborough",
                            GeoID = 1,
                            Street = "Kulas Light",
                            Suite = "Apt. 556",
                            Zipcode = "92998-3874"
                        },
                        new
                        {
                            Id = 2,
                            City = "Wisokyburgh",
                            GeoID = 2,
                            Street = "Victor Plains",
                            Suite = "Suite 879",
                            Zipcode = "90566-7771"
                        });
                });

            modelBuilder.Entity("UserCRUD.DATA.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bs")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("CatchPhrase")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Company");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bs = "harness real-time e-markets",
                            CatchPhrase = "Multi-layered client-server neural-net",
                            Name = "Romaguera-Crona"
                        },
                        new
                        {
                            Id = 2,
                            Bs = "synergize scalable supply-chains",
                            CatchPhrase = "Proactive didactic contingency",
                            Name = "Deckow-Crist"
                        });
                });

            modelBuilder.Entity("UserCRUD.DATA.Entities.Geo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Lat")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Lng")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Geo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Lat = "-37.3159",
                            Lng = "81.1496"
                        },
                        new
                        {
                            Id = 2,
                            Lat = "-43.9509",
                            Lng = "-34.4618"
                        });
                });

            modelBuilder.Entity("UserCRUD.DATA.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Phone")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Username")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Website")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 1,
                            CompanyId = 1,
                            Email = "Sincere@april.biz",
                            Name = "Leanne Graham",
                            Phone = "1-770-736-8031 x56442",
                            Username = "Bret",
                            Website = "hildegard.org"
                        },
                        new
                        {
                            Id = 2,
                            AddressId = 2,
                            CompanyId = 2,
                            Email = "Shanna@melissa.tv",
                            Name = "Ervin Howell",
                            Phone = "010-692-6593 x09125",
                            Username = "Antonette",
                            Website = "anastasia.net"
                        });
                });

            modelBuilder.Entity("UserCRUD.DATA.Entities.Address", b =>
                {
                    b.HasOne("UserCRUD.DATA.Entities.Geo", "Geo")
                        .WithMany()
                        .HasForeignKey("GeoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Geo");
                });

            modelBuilder.Entity("UserCRUD.DATA.Entities.User", b =>
                {
                    b.HasOne("UserCRUD.DATA.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UserCRUD.DATA.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Company");
                });
#pragma warning restore 612, 618
        }
    }
}
