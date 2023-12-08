using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurent.Infrastructures.Migrations
{
    /// <inheritdoc />
    public partial class sdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MenuItemId1",
                table: "orderItems",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "menuItems",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_orderItems_MenuItemId1",
                table: "orderItems",
                column: "MenuItemId1");

            migrationBuilder.AddForeignKey(
                name: "FK_orderItems_menuItems_MenuItemId1",
                table: "orderItems",
                column: "MenuItemId1",
                principalTable: "menuItems",
                principalColumn: "MenuItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderItems_menuItems_MenuItemId1",
                table: "orderItems");

            migrationBuilder.DropIndex(
                name: "IX_orderItems_MenuItemId1",
                table: "orderItems");

            migrationBuilder.DropColumn(
                name: "MenuItemId1",
                table: "orderItems");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "menuItems",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);
        }
    }
}
