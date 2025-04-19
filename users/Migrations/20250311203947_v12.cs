using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace users.Migrations
{
    /// <inheritdoc />
    public partial class v12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                table: "PermissionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ProductionDate",
                table: "PermissionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "PermissionItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PermissionItems_SupplierId",
                table: "PermissionItems",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionItems_Suppliers_SupplierId",
                table: "PermissionItems",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "IdSupplier",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PermissionItems_Suppliers_SupplierId",
                table: "PermissionItems");

            migrationBuilder.DropIndex(
                name: "IX_PermissionItems_SupplierId",
                table: "PermissionItems");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                table: "PermissionItems");

            migrationBuilder.DropColumn(
                name: "ProductionDate",
                table: "PermissionItems");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "PermissionItems");
        }
    }
}
