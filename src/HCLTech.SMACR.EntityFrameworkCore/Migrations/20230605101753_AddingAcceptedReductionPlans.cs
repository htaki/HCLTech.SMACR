using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HCLTech.SMACR.Migrations
{
    /// <inheritdoc />
    public partial class AddingAcceptedReductionPlans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "Profiles",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Profiles",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Profiles",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "AcceptedReductionPlanId",
                table: "EnergyReductionPlans",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AcceptedReductionPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    UserProfileId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatorId = table.Column<Guid>(type: "TEXT", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcceptedReductionPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AcceptedReductionPlans_Profiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnergyReductionPlans_AcceptedReductionPlanId",
                table: "EnergyReductionPlans",
                column: "AcceptedReductionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_AcceptedReductionPlans_UserProfileId",
                table: "AcceptedReductionPlans",
                column: "UserProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_EnergyReductionPlans_AcceptedReductionPlans_AcceptedReductionPlanId",
                table: "EnergyReductionPlans",
                column: "AcceptedReductionPlanId",
                principalTable: "AcceptedReductionPlans",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnergyReductionPlans_AcceptedReductionPlans_AcceptedReductionPlanId",
                table: "EnergyReductionPlans");

            migrationBuilder.DropTable(
                name: "AcceptedReductionPlans");

            migrationBuilder.DropIndex(
                name: "IX_EnergyReductionPlans_AcceptedReductionPlanId",
                table: "EnergyReductionPlans");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "AcceptedReductionPlanId",
                table: "EnergyReductionPlans");
        }
    }
}
