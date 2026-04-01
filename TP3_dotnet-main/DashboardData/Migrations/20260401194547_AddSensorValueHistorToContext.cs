using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DashboardData.Migrations
{
    /// <inheritdoc />
    public partial class AddSensorValueHistorToContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SensorValueHistor_Sensors_SensorDataId",
                table: "SensorValueHistor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SensorValueHistor",
                table: "SensorValueHistor");

            migrationBuilder.RenameTable(
                name: "SensorValueHistor",
                newName: "SensorValueHistories");

            migrationBuilder.RenameIndex(
                name: "IX_SensorValueHistor_SensorDataId",
                table: "SensorValueHistories",
                newName: "IX_SensorValueHistories_SensorDataId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SensorValueHistories",
                table: "SensorValueHistories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SensorValueHistories_Sensors_SensorDataId",
                table: "SensorValueHistories",
                column: "SensorDataId",
                principalTable: "Sensors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SensorValueHistories_Sensors_SensorDataId",
                table: "SensorValueHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SensorValueHistories",
                table: "SensorValueHistories");

            migrationBuilder.RenameTable(
                name: "SensorValueHistories",
                newName: "SensorValueHistor");

            migrationBuilder.RenameIndex(
                name: "IX_SensorValueHistories_SensorDataId",
                table: "SensorValueHistor",
                newName: "IX_SensorValueHistor_SensorDataId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SensorValueHistor",
                table: "SensorValueHistor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SensorValueHistor_Sensors_SensorDataId",
                table: "SensorValueHistor",
                column: "SensorDataId",
                principalTable: "Sensors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
