using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HCLTech.SMACR.Migrations
{
    /// <inheritdoc />
    public partial class addingEmissionFactorsIndexByYearAndCountry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SMACR-EmissionFactors_Year_Country",
                table: "SMACR-EmissionFactors",
                columns: new[] { "Year", "Country" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SMACR-EmissionFactors_Year_Country",
                table: "SMACR-EmissionFactors");
        }
    }
}
