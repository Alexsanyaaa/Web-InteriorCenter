using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InteriorCenterBackend.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "Модульнаякухня.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "Модульнаяспальн.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Кровать, письменный стол, шкаф, полки. Материал: ЛДСП. Цвет: Белый/Голубой.", "МолодежнаяМодель1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Гибкая система мебели, адаптируемая под рост. Материал: ЛДСП. Цвета: на выбор.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Кровать, стол, шкаф, полки. Материал: ЛДСП. Цвет: Крафт-серый.", "Ронда.jpg", "Ронда", 22000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Кровать, стол с полками, шкаф. Материал: ЛДСП. Цвет: Белый/Серый.", "Молодежнаясрабочейзоной.jpg", "Молодежная с рабочей зоной", 20000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "4 ящика. Шкаф с полками Материал: ЛДСП. Цвет: Белый. Размеры: 80х40х90 см.", "Комод.jpg", "Комод", 8000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Открытая конструкция. Материал: ЛДСП. Цвет: Бук. Размеры: 100х30х180 см.", "Стеллаж.jpg", "Стеллаж" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { "3 двери. Материал: ЛДСП. Цвет: Белый/Зеркало. Размеры: 200х60х220 см.", "Шкафкупе.jpg", "Шкаф купе", 15000m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { "Обеденный. Материал: ЛДСП. Цвет столешницы: Белый. Размеры: 120х80 см.", "Стол.jpg", "Стол", 7000m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { "С мягким сиденьем. Материал: деревянный каркас, ткань. Цвет: серый.", "Стул.jpg", "Стул", 2500m, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { "Письменный стол c полкой. Материал: ЛДСП. Цвет: Белый. Размеры: 100х60х75 см.", "Письменныйстол.jpg", "Письменный стол", 6500m, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { "Диван, 2 кресла, журнальный столик. Материал: ткань, ЛДСП. Цвет: бежевый.", "ГостинаяМодель1.jpg", "Гостиная Модель 1", 45000m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { "Угловой диван, столик, ТВ-тумба. Материал: ткань, ЛДСП. Цвет: серый.", "Гостинаямодель2.jpg", "Гостиная модель 2", 52000m, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "Модульная кухня.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "Модульная спальн.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "Молодежная Модель 1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "", "https://interior-center.ru/wp-content/uploads/2024/06/1-5.jpg", "Шкаф", 15000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "", "https://interior-center.ru/wp-content/uploads/2024/06/1-6.jpg", "Прихожая", 18000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "", "https://interior-center.ru/wp-content/uploads/2024/06/1-7.jpg", "Книжный шкаф", 10000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "", "https://interior-center.ru/wp-content/uploads/2024/06/1-8.jpg", "Кресло" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { "", "https://interior-center.ru/wp-content/uploads/2024/06/1-9.jpg", "Журнальный столик", 3500m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { "", "https://interior-center.ru/wp-content/uploads/2024/06/1-10.jpg", "Кухонный гарнитур", 28000m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { "", "https://interior-center.ru/wp-content/uploads/2024/06/1.jpg", "Гостиная Модель 1", 45000m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { "", "https://interior-center.ru/wp-content/uploads/2025/04/Spalnya_4_4-scaled.jpg", "Гостиная с угловым диваном", 52000m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { "", "https://interior-center.ru/wp-content/uploads/2024/06/1-11.jpg", "Спальня Модель 1", 35000m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { "", "https://interior-center.ru/wp-content/uploads/2024/06/1-12.jpg", "Спальня Модель 2", 40000m, 3 });
        }
    }
}
