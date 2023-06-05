using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HCLTech.SMACR.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingDataBased : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SMACR-ElectricConsumptions_SMACR-Profiles_UserProfileId",
                table: "SMACR-ElectricConsumptions");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserProfileId",
                table: "SMACR-ElectricConsumptions",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SMACR-ElectricConsumptions_SMACR-Profiles_UserProfileId",
                table: "SMACR-ElectricConsumptions",
                column: "UserProfileId",
                principalTable: "SMACR-Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SMACR-ElectricConsumptions_SMACR-Profiles_UserProfileId",
                table: "SMACR-ElectricConsumptions");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserProfileId",
                table: "SMACR-ElectricConsumptions",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_SMACR-ElectricConsumptions_SMACR-Profiles_UserProfileId",
                table: "SMACR-ElectricConsumptions",
                column: "UserProfileId",
                principalTable: "SMACR-Profiles",
                principalColumn: "Id");
        }
    }
}
