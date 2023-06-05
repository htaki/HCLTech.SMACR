using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HCLTech.SMACR.Migrations
{
    /// <inheritdoc />
    public partial class AddingTablesPrefix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcceptedReductionPlans_Profiles_UserProfileId",
                table: "AcceptedReductionPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricConsumptions_Profiles_UserProfileId",
                table: "ElectricConsumptions");

            migrationBuilder.DropForeignKey(
                name: "FK_EnergyReductionPlans_AcceptedReductionPlans_AcceptedReductionPlanId",
                table: "EnergyReductionPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_AbpUsers_IdentityUserId",
                table: "Profiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EnergyReductionPlans",
                table: "EnergyReductionPlans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElectricConsumptions",
                table: "ElectricConsumptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AcceptedReductionPlans",
                table: "AcceptedReductionPlans");

            migrationBuilder.RenameTable(
                name: "Profiles",
                newName: "SMACR-Profiles");

            migrationBuilder.RenameTable(
                name: "EnergyReductionPlans",
                newName: "SMACR-EnergyReductionPlans");

            migrationBuilder.RenameTable(
                name: "ElectricConsumptions",
                newName: "SMACR-ElectricConsumptions");

            migrationBuilder.RenameTable(
                name: "AcceptedReductionPlans",
                newName: "SMACR-AcceptedReductionPlans");

            migrationBuilder.RenameIndex(
                name: "IX_Profiles_IdentityUserId",
                table: "SMACR-Profiles",
                newName: "IX_SMACR-Profiles_IdentityUserId");

            migrationBuilder.RenameIndex(
                name: "IX_EnergyReductionPlans_AcceptedReductionPlanId",
                table: "SMACR-EnergyReductionPlans",
                newName: "IX_SMACR-EnergyReductionPlans_AcceptedReductionPlanId");

            migrationBuilder.RenameIndex(
                name: "IX_ElectricConsumptions_UserProfileId",
                table: "SMACR-ElectricConsumptions",
                newName: "IX_SMACR-ElectricConsumptions_UserProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_AcceptedReductionPlans_UserProfileId",
                table: "SMACR-AcceptedReductionPlans",
                newName: "IX_SMACR-AcceptedReductionPlans_UserProfileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SMACR-Profiles",
                table: "SMACR-Profiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SMACR-EnergyReductionPlans",
                table: "SMACR-EnergyReductionPlans",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SMACR-ElectricConsumptions",
                table: "SMACR-ElectricConsumptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SMACR-AcceptedReductionPlans",
                table: "SMACR-AcceptedReductionPlans",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SMACR-AcceptedReductionPlans_SMACR-Profiles_UserProfileId",
                table: "SMACR-AcceptedReductionPlans",
                column: "UserProfileId",
                principalTable: "SMACR-Profiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SMACR-ElectricConsumptions_SMACR-Profiles_UserProfileId",
                table: "SMACR-ElectricConsumptions",
                column: "UserProfileId",
                principalTable: "SMACR-Profiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SMACR-EnergyReductionPlans_SMACR-AcceptedReductionPlans_AcceptedReductionPlanId",
                table: "SMACR-EnergyReductionPlans",
                column: "AcceptedReductionPlanId",
                principalTable: "SMACR-AcceptedReductionPlans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SMACR-Profiles_AbpUsers_IdentityUserId",
                table: "SMACR-Profiles",
                column: "IdentityUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SMACR-AcceptedReductionPlans_SMACR-Profiles_UserProfileId",
                table: "SMACR-AcceptedReductionPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_SMACR-ElectricConsumptions_SMACR-Profiles_UserProfileId",
                table: "SMACR-ElectricConsumptions");

            migrationBuilder.DropForeignKey(
                name: "FK_SMACR-EnergyReductionPlans_SMACR-AcceptedReductionPlans_AcceptedReductionPlanId",
                table: "SMACR-EnergyReductionPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_SMACR-Profiles_AbpUsers_IdentityUserId",
                table: "SMACR-Profiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SMACR-Profiles",
                table: "SMACR-Profiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SMACR-EnergyReductionPlans",
                table: "SMACR-EnergyReductionPlans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SMACR-ElectricConsumptions",
                table: "SMACR-ElectricConsumptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SMACR-AcceptedReductionPlans",
                table: "SMACR-AcceptedReductionPlans");

            migrationBuilder.RenameTable(
                name: "SMACR-Profiles",
                newName: "Profiles");

            migrationBuilder.RenameTable(
                name: "SMACR-EnergyReductionPlans",
                newName: "EnergyReductionPlans");

            migrationBuilder.RenameTable(
                name: "SMACR-ElectricConsumptions",
                newName: "ElectricConsumptions");

            migrationBuilder.RenameTable(
                name: "SMACR-AcceptedReductionPlans",
                newName: "AcceptedReductionPlans");

            migrationBuilder.RenameIndex(
                name: "IX_SMACR-Profiles_IdentityUserId",
                table: "Profiles",
                newName: "IX_Profiles_IdentityUserId");

            migrationBuilder.RenameIndex(
                name: "IX_SMACR-EnergyReductionPlans_AcceptedReductionPlanId",
                table: "EnergyReductionPlans",
                newName: "IX_EnergyReductionPlans_AcceptedReductionPlanId");

            migrationBuilder.RenameIndex(
                name: "IX_SMACR-ElectricConsumptions_UserProfileId",
                table: "ElectricConsumptions",
                newName: "IX_ElectricConsumptions_UserProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_SMACR-AcceptedReductionPlans_UserProfileId",
                table: "AcceptedReductionPlans",
                newName: "IX_AcceptedReductionPlans_UserProfileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EnergyReductionPlans",
                table: "EnergyReductionPlans",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElectricConsumptions",
                table: "ElectricConsumptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AcceptedReductionPlans",
                table: "AcceptedReductionPlans",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AcceptedReductionPlans_Profiles_UserProfileId",
                table: "AcceptedReductionPlans",
                column: "UserProfileId",
                principalTable: "Profiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricConsumptions_Profiles_UserProfileId",
                table: "ElectricConsumptions",
                column: "UserProfileId",
                principalTable: "Profiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EnergyReductionPlans_AcceptedReductionPlans_AcceptedReductionPlanId",
                table: "EnergyReductionPlans",
                column: "AcceptedReductionPlanId",
                principalTable: "AcceptedReductionPlans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_AbpUsers_IdentityUserId",
                table: "Profiles",
                column: "IdentityUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
