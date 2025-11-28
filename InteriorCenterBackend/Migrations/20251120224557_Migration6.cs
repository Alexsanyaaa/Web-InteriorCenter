using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InteriorCenterBackend.Migrations
{
    /// <inheritdoc />
    public partial class Migration6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Reviews");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Reviews",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Гибкая система, которую можно адаптировать под любую планировку. Материал: ЛДСП. Цвета: на выбор.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Современный комплект с интересным дизайном. Включает кровать, письменный стол, шкаф и полки. Материал - ЛДСП. Цвет - Крафт-серый. Удобно и стильно. Молодежно. Красиво");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Открытая конструкция для книг, декоративных предметов и игрушек. Материал - ЛДСП. Цвет - Бук. Размеры: 100х30х180 см. Современный классный дизайн.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "Удобный стул с мягким сиденьем и деревянным каркасом. Материал сиденья - ткань. Цвет - серый. Идеально подходит для кухни");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "Просторная гостиная с угловым диваном, обеспечивающим комфорт для большого количества людей.Материал - ткань, ЛДСП. Цвет - серый.");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Reviews",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Reviews",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Гибкая система мебели, которую можно адаптировать под любую планировку. Материал: ЛДСП. Цвета: на выбор.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Современный комплект с интересным дизайном. Включает кровать, письменный стол, шкаф и полки. Материал - ЛДСП. Цвет - Крафт-серый. Удобно и стильно.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Открытая конструкция для книг, декоративных предметов и игрушек. Материал - ЛДСП. Цвет - Бук. Размеры: 100х30х180 см. Современный дизайн.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "Удобный стул с мягким сиденьем и деревянным каркасом. Материал сиденья - ткань. Цвет - серый. Идеально подходит для кухни или рабочего места.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "Просторная гостиная с угловым диваном, обеспечивающим комфорт для большого количества людей. В комплект входят: диван, столик, ТВ-тумба. Материал - ткань, ЛДСП. Цвет - серый.");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
