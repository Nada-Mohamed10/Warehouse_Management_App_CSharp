using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace users.Migrations
{
    /// <inheritdoc />
    public partial class v33 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplyOrderItem_Products_IdProduct",
                table: "SupplyOrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplyOrderItem_SupplyOrders_SupplyOrderId",
                table: "SupplyOrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplyOrderItem",
                table: "SupplyOrderItem");

            migrationBuilder.RenameTable(
                name: "SupplyOrderItem",
                newName: "SupplyOrderItems");

            migrationBuilder.RenameIndex(
                name: "IX_SupplyOrderItem_SupplyOrderId",
                table: "SupplyOrderItems",
                newName: "IX_SupplyOrderItems_SupplyOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_SupplyOrderItem_IdProduct",
                table: "SupplyOrderItems",
                newName: "IX_SupplyOrderItems_IdProduct");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplyOrderItems",
                table: "SupplyOrderItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyOrderItems_Products_IdProduct",
                table: "SupplyOrderItems",
                column: "IdProduct",
                principalTable: "Products",
                principalColumn: "IdProduct",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyOrderItems_SupplyOrders_SupplyOrderId",
                table: "SupplyOrderItems",
                column: "SupplyOrderId",
                principalTable: "SupplyOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplyOrderItems_Products_IdProduct",
                table: "SupplyOrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplyOrderItems_SupplyOrders_SupplyOrderId",
                table: "SupplyOrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplyOrderItems",
                table: "SupplyOrderItems");

            migrationBuilder.RenameTable(
                name: "SupplyOrderItems",
                newName: "SupplyOrderItem");

            migrationBuilder.RenameIndex(
                name: "IX_SupplyOrderItems_SupplyOrderId",
                table: "SupplyOrderItem",
                newName: "IX_SupplyOrderItem_SupplyOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_SupplyOrderItems_IdProduct",
                table: "SupplyOrderItem",
                newName: "IX_SupplyOrderItem_IdProduct");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplyOrderItem",
                table: "SupplyOrderItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyOrderItem_Products_IdProduct",
                table: "SupplyOrderItem",
                column: "IdProduct",
                principalTable: "Products",
                principalColumn: "IdProduct",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyOrderItem_SupplyOrders_SupplyOrderId",
                table: "SupplyOrderItem",
                column: "SupplyOrderId",
                principalTable: "SupplyOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
