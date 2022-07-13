using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace hyperdevCase.DataAccess.Migrations
{
    public partial class createdbpostgresql : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sirketler",
                columns: table => new
                {
                    sirketID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sirketAdi = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    sirketTur = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    sirketVD = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    sirketVNO = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    sirketIl = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    sirketIlce = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    sirketAdres = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sirketler", x => x.sirketID);
                });

            migrationBuilder.CreateTable(
                name: "Departmanlar",
                columns: table => new
                {
                    departmanID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    departmanSirketIDsirketID = table.Column<int>(type: "integer", nullable: false),
                    departmanAdi = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmanlar", x => x.departmanID);
                    table.ForeignKey(
                        name: "FK_Departmanlar_Sirketler_departmanSirketIDsirketID",
                        column: x => x.departmanSirketIDsirketID,
                        principalTable: "Sirketler",
                        principalColumn: "sirketID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AltDepartmanlar",
                columns: table => new
                {
                    altDepartmanID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ustDepartmanIDdepartmanID = table.Column<int>(type: "integer", nullable: false),
                    altDepartmanAdi = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AltDepartmanlar", x => x.altDepartmanID);
                    table.ForeignKey(
                        name: "FK_AltDepartmanlar_Departmanlar_ustDepartmanIDdepartmanID",
                        column: x => x.ustDepartmanIDdepartmanID,
                        principalTable: "Departmanlar",
                        principalColumn: "departmanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AltDepartmanlar_ustDepartmanIDdepartmanID",
                table: "AltDepartmanlar",
                column: "ustDepartmanIDdepartmanID");

            migrationBuilder.CreateIndex(
                name: "IX_Departmanlar_departmanSirketIDsirketID",
                table: "Departmanlar",
                column: "departmanSirketIDsirketID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AltDepartmanlar");

            migrationBuilder.DropTable(
                name: "Departmanlar");

            migrationBuilder.DropTable(
                name: "Sirketler");
        }
    }
}
