using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfSample.Migrations
{
    /// <inheritdoc />
    public partial class SupplierTableFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_CityId",
                table: "Suppliers",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Cities_CityId",
                table: "Suppliers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Cities_CityId",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_CityId",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Suppliers");
        }
    }
}
