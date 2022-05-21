using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonelPlakaTakibi.Migrations
{
    public partial class Default : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelTelNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelAracPlakasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonelAracÖzellikleri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonelAracVarMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.PersonelId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Personels");
        }
    }
}
