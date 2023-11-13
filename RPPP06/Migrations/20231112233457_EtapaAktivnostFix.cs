using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPPP06.Migrations
{
    /// <inheritdoc />
    public partial class EtapaAktivnostFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aktivnost_Etapa_EtapaId",
                table: "Aktivnost");

            migrationBuilder.DropIndex(
                name: "IX_Aktivnost_EtapaId",
                table: "Aktivnost");

            migrationBuilder.DropColumn(
                name: "EtapaId",
                table: "Aktivnost");

            migrationBuilder.AddColumn<int>(
                name: "AktivnostId",
                table: "Etapa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Etapa_AktivnostId",
                table: "Etapa",
                column: "AktivnostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Etapa_Aktivnost_AktivnostId",
                table: "Etapa",
                column: "AktivnostId",
                principalTable: "Aktivnost",
                principalColumn: "AktivnostId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Etapa_Aktivnost_AktivnostId",
                table: "Etapa");

            migrationBuilder.DropIndex(
                name: "IX_Etapa_AktivnostId",
                table: "Etapa");

            migrationBuilder.DropColumn(
                name: "AktivnostId",
                table: "Etapa");

            migrationBuilder.AddColumn<int>(
                name: "EtapaId",
                table: "Aktivnost",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Aktivnost_EtapaId",
                table: "Aktivnost",
                column: "EtapaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aktivnost_Etapa_EtapaId",
                table: "Aktivnost",
                column: "EtapaId",
                principalTable: "Etapa",
                principalColumn: "EtapaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
