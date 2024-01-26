using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiProduct.Migrations
{
    /// <inheritdoc />
    public partial class AddLogDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Products",
                newName: "Updated_at");

            migrationBuilder.RenameColumn(
                name: "is_deleted",
                table: "Products",
                newName: "Is_deleted");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Products",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Products",
                newName: "Created_at");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Updated_at",
                table: "products",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "Is_deleted",
                table: "products",
                newName: "is_deleted");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "products",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Created_at",
                table: "products",
                newName: "created_at");

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "Id");
        }
    }
}
