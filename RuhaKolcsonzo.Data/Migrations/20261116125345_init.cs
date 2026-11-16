using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RuhaKolcsonzo.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ruhak",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Megnevezes = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Kategoria = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Meret = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NapiDij = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ruhak", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ugyfelek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nev = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ugyfelek", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kolcsonzesek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UgyfelId = table.Column<int>(type: "int", nullable: false),
                    RuhaId = table.Column<int>(type: "int", nullable: false),
                    Kezdet = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TervezettVissza = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VisszahozasDatuma = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kolcsonzesek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kolcsonzesek_Ruhak_RuhaId",
                        column: x => x.RuhaId,
                        principalTable: "Ruhak",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kolcsonzesek_Ugyfelek_UgyfelId",
                        column: x => x.UgyfelId,
                        principalTable: "Ugyfelek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kolcsonzesek_RuhaId",
                table: "Kolcsonzesek",
                column: "RuhaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kolcsonzesek_UgyfelId",
                table: "Kolcsonzesek",
                column: "UgyfelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kolcsonzesek");

            migrationBuilder.DropTable(
                name: "Ruhak");

            migrationBuilder.DropTable(
                name: "Ugyfelek");
        }
    }
}
