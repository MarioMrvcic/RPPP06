using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPPP06.Migrations
{
    /// <inheritdoc />
    public partial class Inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Naručitelj",
                columns: table => new
                {
                    OIB = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iban = table.Column<int>(type: "int", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kontakt = table.Column<int>(type: "int", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Naručitelj", x => x.OIB);
                });

            migrationBuilder.CreateTable(
                name: "Prioritet",
                columns: table => new
                {
                    PrioritetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prioritet", x => x.PrioritetId);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZastavicaAktivnosti = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suradnik",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MjestoStanovanja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrojTelefona = table.Column<int>(type: "int", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NadređeniEmail = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suradnik", x => x.Email);
                    table.ForeignKey(
                        name: "FK_Suradnik_Suradnik_NadređeniEmail",
                        column: x => x.NadređeniEmail,
                        principalTable: "Suradnik",
                        principalColumn: "Email");
                });

            migrationBuilder.CreateTable(
                name: "TipZahtjeva",
                columns: table => new
                {
                    TipZahtjevaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipZahtjeva", x => x.TipZahtjevaId);
                });

            migrationBuilder.CreateTable(
                name: "Uloga",
                columns: table => new
                {
                    UlogaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloga", x => x.UlogaId);
                });

            migrationBuilder.CreateTable(
                name: "VrstaDokumentacije",
                columns: table => new
                {
                    VrstaDokumentacijeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaDokumentacije", x => x.VrstaDokumentacijeId);
                });

            migrationBuilder.CreateTable(
                name: "VrstaPosla",
                columns: table => new
                {
                    VrstaPoslaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaPosla", x => x.VrstaPoslaId);
                });

            migrationBuilder.CreateTable(
                name: "VrstaProjekta",
                columns: table => new
                {
                    VrstaProjektaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaProjekta", x => x.VrstaProjektaId);
                });

            migrationBuilder.CreateTable(
                name: "VrstaTransakcije",
                columns: table => new
                {
                    VrstaTransakcijeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaTransakcije", x => x.VrstaTransakcijeId);
                });

            migrationBuilder.CreateTable(
                name: "SuradnikUloga",
                columns: table => new
                {
                    UlogaId = table.Column<int>(type: "int", nullable: false),
                    SuradnikEmail = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuradnikUloga", x => new { x.SuradnikEmail, x.UlogaId });
                    table.ForeignKey(
                        name: "FK_SuradnikUloga_Suradnik_SuradnikEmail",
                        column: x => x.SuradnikEmail,
                        principalTable: "Suradnik",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SuradnikUloga_Uloga_UlogaId",
                        column: x => x.UlogaId,
                        principalTable: "Uloga",
                        principalColumn: "UlogaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projekt",
                columns: table => new
                {
                    ProjektId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kratica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaniraniPočetak = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaniraniKraj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StvarniPočetak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StvarniKraj = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VrstaProjektaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projekt", x => x.ProjektId);
                    table.ForeignKey(
                        name: "FK_Projekt_VrstaProjekta_VrstaProjektaId",
                        column: x => x.VrstaProjektaId,
                        principalTable: "VrstaProjekta",
                        principalColumn: "VrstaProjektaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dokumentacija",
                columns: table => new
                {
                    DokumentacijaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivDokumentacije = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VrijemeKreacije = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Format = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusDovršenosti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjektId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dokumentacija", x => x.DokumentacijaId);
                    table.ForeignKey(
                        name: "FK_Dokumentacija_Projekt_ProjektId",
                        column: x => x.ProjektId,
                        principalTable: "Projekt",
                        principalColumn: "ProjektId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanProjekta",
                columns: table => new
                {
                    PlanProjektaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaniraniPočetak = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaniraniKraj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StvarniPočetak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StvarniKraj = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjektId = table.Column<int>(type: "int", nullable: false),
                    VoditeljEmail = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanProjekta", x => x.PlanProjektaId);
                    table.ForeignKey(
                        name: "FK_PlanProjekta_Projekt_ProjektId",
                        column: x => x.ProjektId,
                        principalTable: "Projekt",
                        principalColumn: "ProjektId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanProjekta_Suradnik_VoditeljEmail",
                        column: x => x.VoditeljEmail,
                        principalTable: "Suradnik",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjektnaKartica",
                columns: table => new
                {
                    ProjektnaKarticaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Banka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Iban = table.Column<int>(type: "int", nullable: false),
                    Stanje = table.Column<double>(type: "float", nullable: false),
                    ProjektId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjektnaKartica", x => x.ProjektnaKarticaId);
                    table.ForeignKey(
                        name: "FK_ProjektnaKartica_Projekt_ProjektId",
                        column: x => x.ProjektId,
                        principalTable: "Projekt",
                        principalColumn: "ProjektId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SuradnikProjekt",
                columns: table => new
                {
                    ProjektId = table.Column<int>(type: "int", nullable: false),
                    SuradnikEmail = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuradnikProjekt", x => new { x.SuradnikEmail, x.ProjektId });
                    table.ForeignKey(
                        name: "FK_SuradnikProjekt_Projekt_ProjektId",
                        column: x => x.ProjektId,
                        principalTable: "Projekt",
                        principalColumn: "ProjektId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SuradnikProjekt_Suradnik_SuradnikEmail",
                        column: x => x.SuradnikEmail,
                        principalTable: "Suradnik",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DokumentacijaVrstaDokumentacije",
                columns: table => new
                {
                    DokumentacijaId = table.Column<int>(type: "int", nullable: false),
                    VrstaDokumentacijeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DokumentacijaVrstaDokumentacije", x => new { x.DokumentacijaId, x.VrstaDokumentacijeId });
                    table.ForeignKey(
                        name: "FK_DokumentacijaVrstaDokumentacije_Dokumentacija_DokumentacijaId",
                        column: x => x.DokumentacijaId,
                        principalTable: "Dokumentacija",
                        principalColumn: "DokumentacijaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DokumentacijaVrstaDokumentacije_VrstaDokumentacije_VrstaDokumentacijeId",
                        column: x => x.VrstaDokumentacijeId,
                        principalTable: "VrstaDokumentacije",
                        principalColumn: "VrstaDokumentacijeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ugovor",
                columns: table => new
                {
                    UgovorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IbanNaručitelja = table.Column<int>(type: "int", nullable: false),
                    IbanIsporučitelja = table.Column<int>(type: "int", nullable: false),
                    DokumentacijaId = table.Column<int>(type: "int", nullable: false),
                    NaručiteljOIB = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ugovor", x => x.UgovorId);
                    table.ForeignKey(
                        name: "FK_Ugovor_Dokumentacija_DokumentacijaId",
                        column: x => x.DokumentacijaId,
                        principalTable: "Dokumentacija",
                        principalColumn: "DokumentacijaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ugovor_Naručitelj_NaručiteljOIB",
                        column: x => x.NaručiteljOIB,
                        principalTable: "Naručitelj",
                        principalColumn: "OIB",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Etapa",
                columns: table => new
                {
                    EtapaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanProjektaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etapa", x => x.EtapaId);
                    table.ForeignKey(
                        name: "FK_Etapa_PlanProjekta_PlanProjektaId",
                        column: x => x.PlanProjektaId,
                        principalTable: "PlanProjekta",
                        principalColumn: "PlanProjektaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zahtjev",
                columns: table => new
                {
                    ZahtjevId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanProjektaId = table.Column<int>(type: "int", nullable: false),
                    PrioritetId = table.Column<int>(type: "int", nullable: false),
                    TipZahtjevaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zahtjev", x => x.ZahtjevId);
                    table.ForeignKey(
                        name: "FK_Zahtjev_PlanProjekta_PlanProjektaId",
                        column: x => x.PlanProjektaId,
                        principalTable: "PlanProjekta",
                        principalColumn: "PlanProjektaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zahtjev_Prioritet_PrioritetId",
                        column: x => x.PrioritetId,
                        principalTable: "Prioritet",
                        principalColumn: "PrioritetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zahtjev_TipZahtjeva_TipZahtjevaId",
                        column: x => x.TipZahtjevaId,
                        principalTable: "TipZahtjeva",
                        principalColumn: "TipZahtjevaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transakcija",
                columns: table => new
                {
                    TransakcijaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IbanIsporučitelja = table.Column<int>(type: "int", nullable: false),
                    IbanPrimatelja = table.Column<int>(type: "int", nullable: false),
                    Iznos = table.Column<double>(type: "float", nullable: false),
                    ProjektnaKarticaIsporučiteljId = table.Column<int>(type: "int", nullable: true),
                    ProjektnaKarticaPrimateljId = table.Column<int>(type: "int", nullable: true),
                    VrstaTransakcijeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transakcija", x => x.TransakcijaId);
                    table.ForeignKey(
                        name: "FK_Transakcija_ProjektnaKartica_ProjektnaKarticaIsporučiteljId",
                        column: x => x.ProjektnaKarticaIsporučiteljId,
                        principalTable: "ProjektnaKartica",
                        principalColumn: "ProjektnaKarticaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transakcija_ProjektnaKartica_ProjektnaKarticaPrimateljId",
                        column: x => x.ProjektnaKarticaPrimateljId,
                        principalTable: "ProjektnaKartica",
                        principalColumn: "ProjektnaKarticaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transakcija_VrstaTransakcije_VrstaTransakcijeId",
                        column: x => x.VrstaTransakcijeId,
                        principalTable: "VrstaTransakcije",
                        principalColumn: "VrstaTransakcijeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Aktivnost",
                columns: table => new
                {
                    AktivnostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EtapaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aktivnost", x => x.AktivnostId);
                    table.ForeignKey(
                        name: "FK_Aktivnost_Etapa_EtapaId",
                        column: x => x.EtapaId,
                        principalTable: "Etapa",
                        principalColumn: "EtapaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zadatak",
                columns: table => new
                {
                    ZadatakId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OpisZadatka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaniraniPočetak = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaniraniKraj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StvarniPočetak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StvarniKraj = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ZahtjevId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    NositeljEmail = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zadatak", x => x.ZadatakId);
                    table.ForeignKey(
                        name: "FK_Zadatak_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zadatak_Suradnik_NositeljEmail",
                        column: x => x.NositeljEmail,
                        principalTable: "Suradnik",
                        principalColumn: "Email");
                    table.ForeignKey(
                        name: "FK_Zadatak_Zahtjev_ZahtjevId",
                        column: x => x.ZahtjevId,
                        principalTable: "Zahtjev",
                        principalColumn: "ZahtjevId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posao",
                columns: table => new
                {
                    PosaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VrijemePočetkaRada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VrijemeKrajaRada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ZadatakId = table.Column<int>(type: "int", nullable: false),
                    VrstaPoslaId = table.Column<int>(type: "int", nullable: false),
                    SuradnikEmail = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posao", x => x.PosaoId);
                    table.ForeignKey(
                        name: "FK_Posao_Suradnik_SuradnikEmail",
                        column: x => x.SuradnikEmail,
                        principalTable: "Suradnik",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Posao_VrstaPosla_VrstaPoslaId",
                        column: x => x.VrstaPoslaId,
                        principalTable: "VrstaPosla",
                        principalColumn: "VrstaPoslaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posao_Zadatak_ZadatakId",
                        column: x => x.ZadatakId,
                        principalTable: "Zadatak",
                        principalColumn: "ZadatakId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aktivnost_EtapaId",
                table: "Aktivnost",
                column: "EtapaId");

            migrationBuilder.CreateIndex(
                name: "IX_Dokumentacija_ProjektId",
                table: "Dokumentacija",
                column: "ProjektId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DokumentacijaVrstaDokumentacije_VrstaDokumentacijeId",
                table: "DokumentacijaVrstaDokumentacije",
                column: "VrstaDokumentacijeId");

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_PlanProjektaId",
                table: "Etapa",
                column: "PlanProjektaId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanProjekta_ProjektId",
                table: "PlanProjekta",
                column: "ProjektId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlanProjekta_VoditeljEmail",
                table: "PlanProjekta",
                column: "VoditeljEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Posao_SuradnikEmail",
                table: "Posao",
                column: "SuradnikEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Posao_VrstaPoslaId",
                table: "Posao",
                column: "VrstaPoslaId");

            migrationBuilder.CreateIndex(
                name: "IX_Posao_ZadatakId",
                table: "Posao",
                column: "ZadatakId");

            migrationBuilder.CreateIndex(
                name: "IX_Projekt_VrstaProjektaId",
                table: "Projekt",
                column: "VrstaProjektaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjektnaKartica_ProjektId",
                table: "ProjektnaKartica",
                column: "ProjektId");

            migrationBuilder.CreateIndex(
                name: "IX_Suradnik_NadređeniEmail",
                table: "Suradnik",
                column: "NadređeniEmail");

            migrationBuilder.CreateIndex(
                name: "IX_SuradnikProjekt_ProjektId",
                table: "SuradnikProjekt",
                column: "ProjektId");

            migrationBuilder.CreateIndex(
                name: "IX_SuradnikUloga_UlogaId",
                table: "SuradnikUloga",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcija_ProjektnaKarticaIsporučiteljId",
                table: "Transakcija",
                column: "ProjektnaKarticaIsporučiteljId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcija_ProjektnaKarticaPrimateljId",
                table: "Transakcija",
                column: "ProjektnaKarticaPrimateljId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcija_VrstaTransakcijeId",
                table: "Transakcija",
                column: "VrstaTransakcijeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ugovor_DokumentacijaId",
                table: "Ugovor",
                column: "DokumentacijaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ugovor_NaručiteljOIB",
                table: "Ugovor",
                column: "NaručiteljOIB");

            migrationBuilder.CreateIndex(
                name: "IX_Zadatak_NositeljEmail",
                table: "Zadatak",
                column: "NositeljEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Zadatak_StatusId",
                table: "Zadatak",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Zadatak_ZahtjevId",
                table: "Zadatak",
                column: "ZahtjevId");

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
                name: "Aktivnost");

            migrationBuilder.DropTable(
                name: "DokumentacijaVrstaDokumentacije");

            migrationBuilder.DropTable(
                name: "Posao");

            migrationBuilder.DropTable(
                name: "SuradnikProjekt");

            migrationBuilder.DropTable(
                name: "SuradnikUloga");

            migrationBuilder.DropTable(
                name: "Transakcija");

            migrationBuilder.DropTable(
                name: "Ugovor");

            migrationBuilder.DropTable(
                name: "Etapa");

            migrationBuilder.DropTable(
                name: "VrstaDokumentacije");

            migrationBuilder.DropTable(
                name: "VrstaPosla");

            migrationBuilder.DropTable(
                name: "Zadatak");

            migrationBuilder.DropTable(
                name: "Uloga");

            migrationBuilder.DropTable(
                name: "ProjektnaKartica");

            migrationBuilder.DropTable(
                name: "VrstaTransakcije");

            migrationBuilder.DropTable(
                name: "Dokumentacija");

            migrationBuilder.DropTable(
                name: "Naručitelj");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Zahtjev");

            migrationBuilder.DropTable(
                name: "PlanProjekta");

            migrationBuilder.DropTable(
                name: "Prioritet");

            migrationBuilder.DropTable(
                name: "TipZahtjeva");

            migrationBuilder.DropTable(
                name: "Projekt");

            migrationBuilder.DropTable(
                name: "Suradnik");

            migrationBuilder.DropTable(
                name: "VrstaProjekta");
        }
    }
}
