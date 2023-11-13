using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RPPP06.Migrations
{
    /// <inheritdoc />
    public partial class DodavanjeŠifrarnika : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Aktivnost",
                columns: new[] { "AktivnostId", "Ime" },
                values: new object[,]
                {
                    { 1, "Sistem analiza" },
                    { 2, "Testiranje" },
                    { 3, "Razvoj" },
                    { 4, "Isporuka" }
                });

            migrationBuilder.InsertData(
                table: "Prioritet",
                columns: new[] { "PrioritetId", "Ime" },
                values: new object[,]
                {
                    { 1, "Mora biti" },
                    { 2, "Može biti" },
                    { 3, "Neće biti" },
                    { 4, "Treba biti" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "StatusId", "Ime", "ZastavicaAktivnosti" },
                values: new object[,]
                {
                    { 1, "U toku", "Aktivan" },
                    { 2, "Nezapočet", "Neaktivan" },
                    { 3, "Odbačen", "Neaktivan" },
                    { 4, "Dovršen", "Aktivan" },
                    { 5, "Odgođen", "Aktivan" }
                });

            migrationBuilder.InsertData(
                table: "TipZahtjeva",
                columns: new[] { "TipZahtjevaId", "Ime" },
                values: new object[,]
                {
                    { 1, "Poslovni" },
                    { 2, "Sistemski" },
                    { 3, "Korisnički" },
                    { 4, "Funkcionalni" },
                    { 5, "Nefunkcionalni" },
                    { 6, "Sigurnosni" },
                    { 7, "Kulturološki" }
                });

            migrationBuilder.InsertData(
                table: "Uloga",
                columns: new[] { "UlogaId", "Ime" },
                values: new object[,]
                {
                    { 1, "Sistem analitičar" },
                    { 2, "Programer" },
                    { 3, "Sponzor" },
                    { 4, "Tester" },
                    { 5, "Koordinator" },
                    { 6, "Analiza" }
                });

            migrationBuilder.InsertData(
                table: "VrstaDokumentacije",
                columns: new[] { "VrstaDokumentacijeId", "Ime" },
                values: new object[,]
                {
                    { 1, "Ponuda" },
                    { 2, "Ugovor" },
                    { 3, "Dokumentacija izvedenog stanja" }
                });

            migrationBuilder.InsertData(
                table: "VrstaPosla",
                columns: new[] { "VrstaPoslaId", "Ime" },
                values: new object[,]
                {
                    { 1, "Analiza" },
                    { 2, "Projektiranje" },
                    { 3, "Programiranje" },
                    { 4, "Testiranje" },
                    { 5, "Dokumentiranje" },
                    { 6, "Planiranje" }
                });

            migrationBuilder.InsertData(
                table: "VrstaProjekta",
                columns: new[] { "VrstaProjektaId", "Ime" },
                values: new object[,]
                {
                    { 1, "Poslovni" },
                    { 2, "Znanstveni" },
                    { 3, "Nastavni" },
                    { 4, "Istraživačko-razvojni" }
                });

            migrationBuilder.InsertData(
                table: "VrstaTransakcije",
                columns: new[] { "VrstaTransakcijeId", "Ime" },
                values: new object[,]
                {
                    { 1, "Uplata" },
                    { 2, "Isplata" },
                    { 3, "Honorar" },
                    { 4, "Prijenos" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aktivnost",
                keyColumn: "AktivnostId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Aktivnost",
                keyColumn: "AktivnostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Aktivnost",
                keyColumn: "AktivnostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Aktivnost",
                keyColumn: "AktivnostId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Prioritet",
                keyColumn: "PrioritetId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prioritet",
                keyColumn: "PrioritetId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prioritet",
                keyColumn: "PrioritetId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Prioritet",
                keyColumn: "PrioritetId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TipZahtjeva",
                keyColumn: "TipZahtjevaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipZahtjeva",
                keyColumn: "TipZahtjevaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipZahtjeva",
                keyColumn: "TipZahtjevaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TipZahtjeva",
                keyColumn: "TipZahtjevaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TipZahtjeva",
                keyColumn: "TipZahtjevaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TipZahtjeva",
                keyColumn: "TipZahtjevaId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TipZahtjeva",
                keyColumn: "TipZahtjevaId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Uloga",
                keyColumn: "UlogaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Uloga",
                keyColumn: "UlogaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Uloga",
                keyColumn: "UlogaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Uloga",
                keyColumn: "UlogaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Uloga",
                keyColumn: "UlogaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Uloga",
                keyColumn: "UlogaId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VrstaDokumentacije",
                keyColumn: "VrstaDokumentacijeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VrstaDokumentacije",
                keyColumn: "VrstaDokumentacijeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VrstaDokumentacije",
                keyColumn: "VrstaDokumentacijeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VrstaPosla",
                keyColumn: "VrstaPoslaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VrstaPosla",
                keyColumn: "VrstaPoslaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VrstaPosla",
                keyColumn: "VrstaPoslaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VrstaPosla",
                keyColumn: "VrstaPoslaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VrstaPosla",
                keyColumn: "VrstaPoslaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VrstaPosla",
                keyColumn: "VrstaPoslaId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VrstaProjekta",
                keyColumn: "VrstaProjektaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VrstaProjekta",
                keyColumn: "VrstaProjektaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VrstaProjekta",
                keyColumn: "VrstaProjektaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VrstaProjekta",
                keyColumn: "VrstaProjektaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VrstaTransakcije",
                keyColumn: "VrstaTransakcijeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VrstaTransakcije",
                keyColumn: "VrstaTransakcijeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VrstaTransakcije",
                keyColumn: "VrstaTransakcijeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VrstaTransakcije",
                keyColumn: "VrstaTransakcijeId",
                keyValue: 4);
        }
    }
}
