using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace users.Migrations
{
    /// <inheritdoc />
    public partial class v9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplyOrders_Suppliers_SupplierID",
                table: "SupplyOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplyOrders_Warehouses_WarehouseID",
                table: "SupplyOrders");

            migrationBuilder.DropColumn(
                name: "ExpiryDuration",
                table: "SupplyOrders");

            migrationBuilder.RenameColumn(
                name: "WarehouseID",
                table: "SupplyOrders",
                newName: "WarehouseId");

            migrationBuilder.RenameColumn(
                name: "SupplierID",
                table: "SupplyOrders",
                newName: "SupplierId");

            migrationBuilder.RenameColumn(
                name: "OrderNumber",
                table: "SupplyOrders",
                newName: "PermissionNumber");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "SupplyOrders",
                newName: "PermissionDate");

            migrationBuilder.RenameColumn(
                name: "SupplyOrderID",
                table: "SupplyOrders",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_SupplyOrders_WarehouseID",
                table: "SupplyOrders",
                newName: "IX_SupplyOrders_WarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_SupplyOrders_SupplierID",
                table: "SupplyOrders",
                newName: "IX_SupplyOrders_SupplierId");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                table: "SupplyOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "SupplyOrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplyOrderId = table.Column<int>(type: "int", nullable: false),
                    IdProduct = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyOrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupplyOrderItem_Products_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "Products",
                        principalColumn: "IdProduct",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyOrderItem_SupplyOrders_SupplyOrderId",
                        column: x => x.SupplyOrderId,
                        principalTable: "SupplyOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplyOrderItem_IdProduct",
                table: "SupplyOrderItem",
                column: "IdProduct");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyOrderItem_SupplyOrderId",
                table: "SupplyOrderItem",
                column: "SupplyOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyOrders_Suppliers_SupplierId",
                table: "SupplyOrders",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "IdSupplier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyOrders_Warehouses_WarehouseId",
                table: "SupplyOrders",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "IdWarehouse",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplyOrders_Suppliers_SupplierId",
                table: "SupplyOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplyOrders_Warehouses_WarehouseId",
                table: "SupplyOrders");

            migrationBuilder.DropTable(
                name: "SupplyOrderItem");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                table: "SupplyOrders");

            migrationBuilder.RenameColumn(
                name: "WarehouseId",
                table: "SupplyOrders",
                newName: "WarehouseID");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "SupplyOrders",
                newName: "SupplierID");

            migrationBuilder.RenameColumn(
                name: "PermissionNumber",
                table: "SupplyOrders",
                newName: "OrderNumber");

            migrationBuilder.RenameColumn(
                name: "PermissionDate",
                table: "SupplyOrders",
                newName: "OrderDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SupplyOrders",
                newName: "SupplyOrderID");

            migrationBuilder.RenameIndex(
                name: "IX_SupplyOrders_WarehouseId",
                table: "SupplyOrders",
                newName: "IX_SupplyOrders_WarehouseID");

            migrationBuilder.RenameIndex(
                name: "IX_SupplyOrders_SupplierId",
                table: "SupplyOrders",
                newName: "IX_SupplyOrders_SupplierID");

            migrationBuilder.AddColumn<int>(
                name: "ExpiryDuration",
                table: "SupplyOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyOrders_Suppliers_SupplierID",
                table: "SupplyOrders",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "IdSupplier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyOrders_Warehouses_WarehouseID",
                table: "SupplyOrders",
                column: "WarehouseID",
                principalTable: "Warehouses",
                principalColumn: "IdWarehouse",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
