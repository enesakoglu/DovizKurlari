using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DovizKurlari.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InternetKurlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DovizKodu = table.Column<int>(type: "integer", nullable: false),
                    Doviz = table.Column<string>(type: "text", nullable: true),
                    CaprazKur = table.Column<int>(type: "integer", nullable: false),
                    DovizAlis = table.Column<int>(type: "integer", nullable: false),
                    DovizSatis = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternetKurlari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarbasPariteleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PariteCinsi = table.Column<string>(type: "text", nullable: true),
                    AlisParitesi = table.Column<int>(type: "integer", nullable: false),
                    SatisParitesi = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarbasPariteleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SerbestKurlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EfektifAlis = table.Column<int>(type: "integer", nullable: false),
                    EfektifSatis = table.Column<int>(type: "integer", nullable: false),
                    DovizKodu = table.Column<int>(type: "integer", nullable: false),
                    Doviz = table.Column<string>(type: "text", nullable: true),
                    CaprazKur = table.Column<int>(type: "integer", nullable: false),
                    DovizAlis = table.Column<int>(type: "integer", nullable: false),
                    DovizSatis = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerbestKurlar", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InternetKurlari");

            migrationBuilder.DropTable(
                name: "MarbasPariteleri");

            migrationBuilder.DropTable(
                name: "SerbestKurlar");
        }
    }
}
