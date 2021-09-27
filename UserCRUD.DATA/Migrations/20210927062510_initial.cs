using Microsoft.EntityFrameworkCore.Migrations;

namespace UserCRUD.DATA.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CatchPhrase = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Bs = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Geo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lat = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Lng = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Suite = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    City = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Zipcode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    GeoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_Geo_GeoID",
                        column: x => x.GeoID,
                        principalTable: "Geo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Username = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Website = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "Bs", "CatchPhrase", "Name" },
                values: new object[,]
                {
                    { 1, "harness real-time e-markets", "Multi-layered client-server neural-net", "Romaguera-Crona" },
                    { 2, "synergize scalable supply-chains", "Proactive didactic contingency", "Deckow-Crist" }
                });

            migrationBuilder.InsertData(
                table: "Geo",
                columns: new[] { "Id", "Lat", "Lng" },
                values: new object[,]
                {
                    { 1, "-37.3159", "81.1496" },
                    { 2, "-43.9509", "-34.4618" }
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "GeoID", "Street", "Suite", "Zipcode" },
                values: new object[] { 1, "Gwenborough", 1, "Kulas Light", "Apt. 556", "92998-3874" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "GeoID", "Street", "Suite", "Zipcode" },
                values: new object[] { 2, "Wisokyburgh", 2, "Victor Plains", "Suite 879", "90566-7771" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AddressId", "CompanyId", "Email", "Name", "Phone", "Username", "Website" },
                values: new object[] { 1, 1, 1, "Sincere@april.biz", "Leanne Graham", "1-770-736-8031 x56442", "Bret", "hildegard.org" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AddressId", "CompanyId", "Email", "Name", "Phone", "Username", "Website" },
                values: new object[] { 2, 2, 2, "Shanna@melissa.tv", "Ervin Howell", "010-692-6593 x09125", "Antonette", "anastasia.net" });

            migrationBuilder.CreateIndex(
                name: "IX_Address_GeoID",
                table: "Address",
                column: "GeoID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AddressId",
                table: "Users",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CompanyId",
                table: "Users",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Geo");
        }
    }
}
