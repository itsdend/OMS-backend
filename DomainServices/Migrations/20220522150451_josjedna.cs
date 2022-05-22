using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DomainServices.Migrations
{
    public partial class josjedna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kategorijaopreme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Naziv = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kategorijaopreme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "oprema",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Naziv = table.Column<string>(type: "text", nullable: true),
                    Cijena = table.Column<decimal>(type: "numeric", nullable: true),
                    Datumkupnje = table.Column<DateOnly>(type: "date", nullable: true),
                    Serijskibroj = table.Column<string>(type: "text", nullable: true),
                    Opis = table.Column<string>(type: "text", nullable: true),
                    FkKategorijaid = table.Column<int>(type: "integer", nullable: true),
                    FkTrenutnivlasnikid = table.Column<int>(type: "integer", nullable: true),
                    FkPrethodnivlasnikid = table.Column<int>(type: "integer", nullable: true),
                    FkStatusid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oprema", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "osoba",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Oib = table.Column<string>(type: "text", nullable: true),
                    Ime = table.Column<string>(type: "text", nullable: true),
                    Prezime = table.Column<string>(type: "text", nullable: true),
                    Datumrodenja = table.Column<DateOnly>(type: "date", nullable: true),
                    Datumzaposljenja = table.Column<DateOnly>(type: "date", nullable: true),
                    Lozinka = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Kontaktbr = table.Column<string>(type: "text", nullable: true),
                    Jezaposlen = table.Column<bool>(type: "boolean", nullable: true),
                    FkTimid = table.Column<int>(type: "integer", nullable: true),
                    FkUlogaid = table.Column<int>(type: "integer", nullable: true),
                    FkPozicijaid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_osoba", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pozicija",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Naziv = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pozicija", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "statusopreme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Naziv = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statusopreme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Naziv = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "uloga",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Naziv = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_uloga", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kategorijaopreme");

            migrationBuilder.DropTable(
                name: "oprema");

            migrationBuilder.DropTable(
                name: "osoba");

            migrationBuilder.DropTable(
                name: "pozicija");

            migrationBuilder.DropTable(
                name: "statusopreme");

            migrationBuilder.DropTable(
                name: "tim");

            migrationBuilder.DropTable(
                name: "uloga");
        }
    }
}
