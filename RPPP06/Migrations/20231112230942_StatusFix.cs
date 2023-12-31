﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPPP06.Migrations
{
    /// <inheritdoc />
    public partial class StatusFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Status",
                newName: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Status",
                newName: "Id");
        }
    }
}
