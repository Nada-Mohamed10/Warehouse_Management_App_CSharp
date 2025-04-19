using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace users.Migrations
{
    /// <inheritdoc />
    public partial class v11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Suppliers_SupplierId",
                table: "Permissions");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "Permissions",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_SupplierId",
                table: "Permissions",
                newName: "IX_Permissions_CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Customers_CustomerId",
                table: "Permissions",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "IdCustomer",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Customers_CustomerId",
                table: "Permissions");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Permissions",
                newName: "SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_CustomerId",
                table: "Permissions",
                newName: "IX_Permissions_SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Suppliers_SupplierId",
                table: "Permissions",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "IdSupplier",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
