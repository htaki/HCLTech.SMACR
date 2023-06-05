using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HCLTech.SMACR.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "SMACR-ElectricConsumptions");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "SMACR-ElectricConsumptions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SMACR-ElectricConsumptions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "SMACR-ElectricConsumptions",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "SMACR-ElectricConsumptions",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SMACR-ElectricConsumptions",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
