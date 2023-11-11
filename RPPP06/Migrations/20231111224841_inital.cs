using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPPP06.Migrations
{
    /// <inheritdoc />
    public partial class inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Format",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Format", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Naručitelj",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Naručitelj", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nositelj",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nositelj", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prioritet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prioritet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projekt",
                columns: table => new
                {
                    SifProjekt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projekt", x => x.SifProjekt);
                });

            migrationBuilder.CreateTable(
                name: "Suradnik",
                columns: table => new
                {
                    OIB = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuradnikOIB = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suradnik", x => x.OIB);
                    table.ForeignKey(
                        name: "FK_Suradnik_Suradnik_SuradnikOIB",
                        column: x => x.SuradnikOIB,
                        principalTable: "Suradnik",
                        principalColumn: "OIB");
                });

            migrationBuilder.CreateTable(
                name: "TipZahtjeva",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipZahtjeva", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uloga",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloga", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VrstaDokumentacije",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaDokumentacije", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VrstaPosla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaPosla", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VrstaTransakcije",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaTransakcije", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ZastavicaAktivnosti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZastavicaAktivnosti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dokumentacija",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dokumentacija", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dokumentacija_Projekt_Id",
                        column: x => x.Id,
                        principalTable: "Projekt",
                        principalColumn: "SifProjekt",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanProjekta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanProjekta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanProjekta_Projekt_Id",
                        column: x => x.Id,
                        principalTable: "Projekt",
                        principalColumn: "SifProjekt",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjektnaKartica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Banka = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjektnaKartica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjektnaKartica_Projekt_Id",
                        column: x => x.Id,
                        principalTable: "Projekt",
                        principalColumn: "SifProjekt",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RadeNa",
                columns: table => new
                {
                    ProjektId = table.Column<int>(type: "int", nullable: false),
                    SuradnikOIB = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RadeNa", x => new { x.SuradnikOIB, x.ProjektId });
                    table.ForeignKey(
                        name: "FK_RadeNa_Projekt_SuradnikOIB",
                        column: x => x.SuradnikOIB,
                        principalTable: "Projekt",
                        principalColumn: "SifProjekt",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RadeNa_Suradnik_ProjektId",
                        column: x => x.ProjektId,
                        principalTable: "Suradnik",
                        principalColumn: "OIB",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ima",
                columns: table => new
                {
                    UlogaId = table.Column<int>(type: "int", nullable: false),
                    SuradnikOIB = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ima", x => new { x.SuradnikOIB, x.UlogaId });
                    table.ForeignKey(
                        name: "FK_Ima_Suradnik_UlogaId",
                        column: x => x.UlogaId,
                        principalTable: "Suradnik",
                        principalColumn: "OIB",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ima_Uloga_SuradnikOIB",
                        column: x => x.SuradnikOIB,
                        principalTable: "Uloga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvidencijaRadnogVremena",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VrstaPoslaId = table.Column<int>(type: "int", nullable: false),
                    SuradnikOIB = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvidencijaRadnogVremena", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvidencijaRadnogVremena_Suradnik_SuradnikOIB",
                        column: x => x.SuradnikOIB,
                        principalTable: "Suradnik",
                        principalColumn: "OIB",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EvidencijaRadnogVremena_VrstaPosla_VrstaPoslaId",
                        column: x => x.VrstaPoslaId,
                        principalTable: "VrstaPosla",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZastavicaAktivnostiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Status_ZastavicaAktivnosti_ZastavicaAktivnostiId",
                        column: x => x.ZastavicaAktivnostiId,
                        principalTable: "ZastavicaAktivnosti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DijeliSeNa",
                columns: table => new
                {
                    DokumentacijaId = table.Column<int>(type: "int", nullable: false),
                    VrstaDokumentacijeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DijeliSeNa", x => new { x.DokumentacijaId, x.VrstaDokumentacijeId });
                    table.ForeignKey(
                        name: "FK_DijeliSeNa_Dokumentacija_DokumentacijaId",
                        column: x => x.DokumentacijaId,
                        principalTable: "Dokumentacija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DijeliSeNa_VrstaDokumentacije_VrstaDokumentacijeId",
                        column: x => x.VrstaDokumentacijeId,
                        principalTable: "VrstaDokumentacije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImaSvoj",
                columns: table => new
                {
                    DokumentacijaId = table.Column<int>(type: "int", nullable: false),
                    FormatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImaSvoj", x => new { x.DokumentacijaId, x.FormatId });
                    table.ForeignKey(
                        name: "FK_ImaSvoj_Dokumentacija_DokumentacijaId",
                        column: x => x.DokumentacijaId,
                        principalTable: "Dokumentacija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImaSvoj_Format_FormatId",
                        column: x => x.FormatId,
                        principalTable: "Format",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ugovor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NaručiteljId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ugovor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ugovor_Dokumentacija_Id",
                        column: x => x.Id,
                        principalTable: "Dokumentacija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ugovor_Naručitelj_NaručiteljId",
                        column: x => x.NaručiteljId,
                        principalTable: "Naručitelj",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zahtjev",
                columns: table => new
                {
                    ŠifZahtjeva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanProjektaId = table.Column<int>(type: "int", nullable: false),
                    PrioritetId = table.Column<int>(type: "int", nullable: false),
                    TipZahtjevaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zahtjev", x => x.ŠifZahtjeva);
                    table.ForeignKey(
                        name: "FK_Zahtjev_PlanProjekta_PlanProjektaId",
                        column: x => x.PlanProjektaId,
                        principalTable: "PlanProjekta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zahtjev_Prioritet_PrioritetId",
                        column: x => x.PrioritetId,
                        principalTable: "Prioritet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zahtjev_TipZahtjeva_TipZahtjevaId",
                        column: x => x.TipZahtjevaId,
                        principalTable: "TipZahtjeva",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transakcija",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjektnaKarticaId = table.Column<int>(type: "int", nullable: false),
                    VrstaTransakcijeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transakcija", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transakcija_ProjektnaKartica_ProjektnaKarticaId",
                        column: x => x.ProjektnaKarticaId,
                        principalTable: "ProjektnaKartica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transakcija_VrstaTransakcije_VrstaTransakcijeId",
                        column: x => x.VrstaTransakcijeId,
                        principalTable: "VrstaTransakcije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zadatak",
                columns: table => new
                {
                    ŠifZad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZahtjevŠifZahtjeva = table.Column<int>(type: "int", nullable: false),
                    NositeljId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    SuradnikOIB = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zadatak", x => x.ŠifZad);
                    table.ForeignKey(
                        name: "FK_Zadatak_Nositelj_NositeljId",
                        column: x => x.NositeljId,
                        principalTable: "Nositelj",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zadatak_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zadatak_Suradnik_SuradnikOIB",
                        column: x => x.SuradnikOIB,
                        principalTable: "Suradnik",
                        principalColumn: "OIB",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zadatak_Zahtjev_ZahtjevŠifZahtjeva",
                        column: x => x.ZahtjevŠifZahtjeva,
                        principalTable: "Zahtjev",
                        principalColumn: "ŠifZahtjeva",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DijeliSeNa_VrstaDokumentacijeId",
                table: "DijeliSeNa",
                column: "VrstaDokumentacijeId");

            migrationBuilder.CreateIndex(
                name: "IX_EvidencijaRadnogVremena_SuradnikOIB",
                table: "EvidencijaRadnogVremena",
                column: "SuradnikOIB");

            migrationBuilder.CreateIndex(
                name: "IX_EvidencijaRadnogVremena_VrstaPoslaId",
                table: "EvidencijaRadnogVremena",
                column: "VrstaPoslaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ima_UlogaId",
                table: "Ima",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_ImaSvoj_FormatId",
                table: "ImaSvoj",
                column: "FormatId");

            migrationBuilder.CreateIndex(
                name: "IX_RadeNa_ProjektId",
                table: "RadeNa",
                column: "ProjektId");

            migrationBuilder.CreateIndex(
                name: "IX_Status_ZastavicaAktivnostiId",
                table: "Status",
                column: "ZastavicaAktivnostiId");

            migrationBuilder.CreateIndex(
                name: "IX_Suradnik_SuradnikOIB",
                table: "Suradnik",
                column: "SuradnikOIB");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcija_ProjektnaKarticaId",
                table: "Transakcija",
                column: "ProjektnaKarticaId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcija_VrstaTransakcijeId",
                table: "Transakcija",
                column: "VrstaTransakcijeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ugovor_NaručiteljId",
                table: "Ugovor",
                column: "NaručiteljId");

            migrationBuilder.CreateIndex(
                name: "IX_Zadatak_NositeljId",
                table: "Zadatak",
                column: "NositeljId");

            migrationBuilder.CreateIndex(
                name: "IX_Zadatak_StatusId",
                table: "Zadatak",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Zadatak_SuradnikOIB",
                table: "Zadatak",
                column: "SuradnikOIB");

            migrationBuilder.CreateIndex(
                name: "IX_Zadatak_ZahtjevŠifZahtjeva",
                table: "Zadatak",
                column: "ZahtjevŠifZahtjeva");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjev_PlanProjektaId",
                table: "Zahtjev",
                column: "PlanProjektaId");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjev_PrioritetId",
                table: "Zahtjev",
                column: "PrioritetId");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjev_TipZahtjevaId",
                table: "Zahtjev",
                column: "TipZahtjevaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DijeliSeNa");

            migrationBuilder.DropTable(
                name: "EvidencijaRadnogVremena");

            migrationBuilder.DropTable(
                name: "Ima");

            migrationBuilder.DropTable(
                name: "ImaSvoj");

            migrationBuilder.DropTable(
                name: "RadeNa");

            migrationBuilder.DropTable(
                name: "Transakcija");

            migrationBuilder.DropTable(
                name: "Ugovor");

            migrationBuilder.DropTable(
                name: "Zadatak");

            migrationBuilder.DropTable(
                name: "VrstaDokumentacije");

            migrationBuilder.DropTable(
                name: "VrstaPosla");

            migrationBuilder.DropTable(
                name: "Uloga");

            migrationBuilder.DropTable(
                name: "Format");

            migrationBuilder.DropTable(
                name: "ProjektnaKartica");

            migrationBuilder.DropTable(
                name: "VrstaTransakcije");

            migrationBuilder.DropTable(
                name: "Dokumentacija");

            migrationBuilder.DropTable(
                name: "Naručitelj");

            migrationBuilder.DropTable(
                name: "Nositelj");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Suradnik");

            migrationBuilder.DropTable(
                name: "Zahtjev");

            migrationBuilder.DropTable(
                name: "ZastavicaAktivnosti");

            migrationBuilder.DropTable(
                name: "PlanProjekta");

            migrationBuilder.DropTable(
                name: "Prioritet");

            migrationBuilder.DropTable(
                name: "TipZahtjeva");

            migrationBuilder.DropTable(
                name: "Projekt");
        }
    }
}
