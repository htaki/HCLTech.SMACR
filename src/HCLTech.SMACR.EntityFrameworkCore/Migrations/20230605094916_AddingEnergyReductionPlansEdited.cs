using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HCLTech.SMACR.Migrations
{
    /// <inheritdoc />
    public partial class AddingEnergyReductionPlansEdited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Profiles",
                schema: "RMAC",
                newName: "Profiles");

            migrationBuilder.CreateTable(
                name: "EnergyReductionPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    PlanNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    ReductionInKw = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnergyReductionPlans", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnergyReductionPlans");

            migrationBuilder.EnsureSchema(
                name: "RMAC");

            migrationBuilder.RenameTable(
                name: "Profiles",
                newName: "Profiles",
                newSchema: "RMAC");
        }
    }
}
