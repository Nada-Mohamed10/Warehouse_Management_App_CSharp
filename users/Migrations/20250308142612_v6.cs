using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace users.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WarehouseProduct_Products_IdProduct",
                table: "WarehouseProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_WarehouseProduct_Warehouses_IdWarehouse",
                table: "WarehouseProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WarehouseProduct",
                table: "WarehouseProduct");

            migrationBuilder.RenameTable(
                name: "WarehouseProduct",
                newName: "WarehouseProducts");

            migrationBuilder.RenameIndex(
                name: "IX_WarehouseProduct_IdWarehouse",
                table: "WarehouseProducts",
                newName: "IX_WarehouseProducts_IdWarehouse");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "WarehouseProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WarehouseProducts",
                table: "WarehouseProducts",
                columns: new[] { "IdProduct", "IdWarehouse" });

            migrationBuilder.AddForeignKey(
                name: "FK_WarehouseProducts_Products_IdProduct",
                table: "WarehouseProducts",
                column: "IdProduct",
                principalTable: "Products",
                principalColumn: "IdProduct",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WarehouseProducts_Warehouses_IdWarehouse",
                table: "WarehouseProducts",
                column: "IdWarehouse",
                principalTable: "Warehouses",
                principalColumn: "IdWarehouse",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WarehouseProducts_Products_IdProduct",
                table: "WarehouseProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_WarehouseProducts_Warehouses_IdWarehouse",
                table: "WarehouseProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WarehouseProducts",
                table: "WarehouseProducts");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "WarehouseProducts");

            migrationBuilder.RenameTable(
                name: "WarehouseProducts",
                newName: "WarehouseProduct");

            migrationBuilder.RenameIndex(
                name: "IX_WarehouseProducts_IdWarehouse",
                table: "WarehouseProduct",
                newName: "IX_WarehouseProduct_IdWarehouse");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WarehouseProduct",
                table: "WarehouseProduct",
                columns: new[] { "IdProduct", "IdWarehouse" });

            migrationBuilder.AddForeignKey(
                name: "FK_WarehouseProduct_Products_IdProduct",
                table: "WarehouseProduct",
                column: "IdProduct",
                principalTable: "Products",
                principalColumn: "IdProduct",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WarehouseProduct_Warehouses_IdWarehouse",
                table: "WarehouseProduct",
                column: "IdWarehouse",
                principalTable: "Warehouses",
                principalColumn: "IdWarehouse",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
