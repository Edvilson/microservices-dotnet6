using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GeekShopping.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductDataTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "T-Shirt", "Description", "https://github.com/Edvilson/microservices-dotnet6/blob/main/GeekShooping/ShoppingImages/6_spacex.jpg", "Name2", 79.9m },
                    { 3L, "Action figure", "Description3", "https://github.com/Edvilson/microservices-dotnet6/blob/main/GeekShooping/ShoppingImages/6_spacex.jpg", "Name3", 999.9m },
                    { 4L, "Picture", "Description4", "https://github.com/Edvilson/microservices-dotnet6/blob/main/GeekShooping/ShoppingImages/6_spacex.jpg", "Name4", 99.9m },
                    { 5L, "T-Shirt", "Description5", "https://github.com/Edvilson/microservices-dotnet6/blob/main/GeekShooping/ShoppingImages/6_spacex.jpg", "Name5", 79.25m },
                    { 6L, "Pants", "Description6", "https://github.com/Edvilson/microservices-dotnet6/blob/main/GeekShooping/ShoppingImages/6_spacex.jpg", "Name6", 129.9m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);
        }
    }
}
