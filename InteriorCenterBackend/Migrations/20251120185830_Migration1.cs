using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InteriorCenterBackend.Migrations
{
    /// <inheritdoc />
    public partial class Migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "КухняМодель1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "КухняМодель2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "Модульная кухня.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Name", "Price" },
                values: new object[] { "КухняCOстровом.jpg", "Кухня с островом", 32000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "Name", "Price" },
                values: new object[] { "СпальняМодель1.jpg", "Спальня Модель 1", 25000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "Name", "Price" },
                values: new object[] { "Модульная спальн.jpg", "Модульная спальня", 30000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "Name", "Price" },
                values: new object[] { "КроватьОртопедическая.jpg", "Кровать ортопедическая", 12000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "Name", "Price" },
                values: new object[] { "Спальнясбалдахином.jpg", "Спальня с балдахином", 35000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "Name", "Price" },
                values: new object[] { "Молодежная Модель 1.jpg", "Молодежная Модель 1", 18000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "Name", "Price" },
                values: new object[] { "Модульнаямолодежная.jpg", "Модульная молодежная", 24000m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://interior-center.ru/wp-content/uploads/2024/06/1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://interior-center.ru/wp-content/uploads/2024/06/3-1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://interior-center.ru/wp-content/uploads/2024/06/3.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Name", "Price" },
                values: new object[] { "https://interior-center.ru/wp-content/uploads/2024/06/3.jpg", "Кровать", 12000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "Name", "Price" },
                values: new object[] { "https://interior-center.ru/wp-content/uploads/2024/06/27.jpg", "Комод", 8000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "Name", "Price" },
                values: new object[] { "https://interior-center.ru/wp-content/uploads/2025/02/СТП06-1200_Белый.jpg", "Письменный стол", 6500m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "Name", "Price" },
                values: new object[] { "https://interior-center.ru/wp-content/uploads/2024/06/1-1.jpg", "Диван", 25000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "Name", "Price" },
                values: new object[] { "https://interior-center.ru/wp-content/uploads/2024/06/1-2.jpg", "Тумба под ТВ", 7000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "Name", "Price" },
                values: new object[] { "https://interior-center.ru/wp-content/uploads/2024/06/1-3.jpg", "Стол обеденный", 9000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "Name", "Price" },
                values: new object[] { "https://interior-center.ru/wp-content/uploads/2024/06/1-4.jpg", "Стул", 2500m });
        }
    }
}
