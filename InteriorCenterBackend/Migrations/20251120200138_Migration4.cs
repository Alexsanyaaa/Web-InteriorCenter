using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InteriorCenterBackend.Migrations
{
    /// <inheritdoc />
    public partial class Migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Компактный кухонный гарнитур для небольшой кухни. Материал: ЛДСП. Цвет: Белый. Размеры: 200х100х80 см.", "Pic\\КухняМодель1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Угловая кухня с вместительными шкафами. Материал: ЛДСП. Цвет: Бежевый. Размеры: 250х150х80 см.", "Pic\\КухняМодель2.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Гибкая система мебели, которую можно адаптировать под любую планировку. Материал: ЛДСП. Цвета: на выбор.", "Pic\\Модульнаякухня.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Просторная кухня с островом для готовки и хранения. Материал: ЛДСП. Цвет: Серый/Белый. Размеры: 300х200х80 см.", "Pic\\КухняCOстровом.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Уютный комплект из кровати, тумбочек и шкафа. Материал - ЛДСП. Цвет - Белый/Серый. Идеально подходит для молодой семьи.", "Pic\\СпальняМодель1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Просторный гарнитур с изголовьем кровати, прикроватными тумбами, комодом и шкафом-купе. Материал - массив сосны. Цвет - Орех.", "Pic\\Модульнаяспальн.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Удобная и прочная конструкция с ортопедическим основанием. Различные размеры и варианты обивки.", "Pic\\КроватьОртопедическая.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Роскошная спальня с балдахином и полным комплектом мебели. Материал: ЛДСП, ткань. Цвет: Бежевый. Создаст романтичную атмосферу.", "Pic\\Спальнясбалдахином.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Яркий и функциональный комплект для подростковой комнаты. Включает кровать, письменный стол, шкаф и полки. Материал - ЛДСП. Цвет - Белый/Голубой. Много места для хранения и учебы.", "Pic\\МолодежнаяМодель1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Гибкая система мебели, которую можно адаптировать под рост и предпочтения ребенка. Многофункциональные элементы. Материал - ЛДСП. Цвета - на выбор. Возможна индивидуальная сборка.", "Pic\\Модульнаямолодежная.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Современный комплект с интересным дизайном. Включает кровать, письменный стол, шкаф и полки. Материал - ЛДСП. Цвет - Крафт-серый. Удобно и стильно.", "Pic\\Ронда.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Комплект, включающий удобную кровать и полноценную рабочую зону с полками. Материал - ЛДСП. Цвет - Белый/Серый. Отличное решение для школьника или студента.", "Pic\\Молодежнаясрабочейзоной.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Вместительный комод с 4 ящиками для хранения постельного белья, одежды и мелочей. Материал - ЛДСП. Цвет - Белый. Размеры: 80х40х90 см. Классический дизайн.", "Pic\\Комод.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Открытая конструкция для книг, декоративных предметов и игрушек. Материал - ЛДСП. Цвет - Бук. Размеры: 100х30х180 см. Современный дизайн.", "Pic\\Стеллаж.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Вместительный шкаф купе с 3 дверями. Материал - ЛДСП. Цвет - Белый/Зеркало. Размеры: 200х60х220 см. Отличное решение для хранения одежды и обуви.", "Pic\\Шкафкупе.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Обеденный стол из прочного ЛДСП. Доступны различные размеры и цвета столешницы. Каркас - металл. Размеры: 120х80 см. Подходит для 4-6 человек.", "Pic\\Стол.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Удобный стул с мягким сиденьем и деревянным каркасом. Материал сиденья - ткань. Цвет - серый. Идеально подходит для кухни или рабочего места.", "Pic\\Стул.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Удобный стол для работы или учебы с дополнительной полкой для книг и канцелярии. Материал - ЛДСП. Цвет - Белый. Размеры: 100х60х75 см.", "Pic\\Письменныйстол.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Удобный комплект для гостиной, включающий диван, 2 кресла и журнальный столик. Материал обивки - ткань. Материал столика - ЛДСП. Цвет - бежевый. Создаст уютную атмосферу.", "Pic\\ГостинаяМодель1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Просторная гостиная с угловым диваном, обеспечивающим комфорт для большого количества людей. В комплект входят: диван, столик, ТВ-тумба. Материал - ткань, ЛДСП. Цвет - серый.", "Pic\\Гостинаямодель2.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "КухняМодель1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "КухняМодель2.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "Модульнаякухня.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "КухняCOстровом.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "СпальняМодель1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "Модульнаяспальн.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "КроватьОртопедическая.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "Спальнясбалдахином.jpg" });

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
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Гибкая система мебели, адаптируемая под рост. Материал: ЛДСП. Цвета: на выбор.", "Модульнаямолодежная.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Кровать, стол, шкаф, полки. Материал: ЛДСП. Цвет: Крафт-серый.", "Ронда.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Кровать, стол с полками, шкаф. Материал: ЛДСП. Цвет: Белый/Серый.", "Молодежнаясрабочейзоной.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "4 ящика. Шкаф с полками Материал: ЛДСП. Цвет: Белый. Размеры: 80х40х90 см.", "Комод.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Открытая конструкция. Материал: ЛДСП. Цвет: Бук. Размеры: 100х30х180 см.", "Стеллаж.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "3 двери. Материал: ЛДСП. Цвет: Белый/Зеркало. Размеры: 200х60х220 см.", "Шкафкупе.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Обеденный. Материал: ЛДСП. Цвет столешницы: Белый. Размеры: 120х80 см.", "Стол.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "С мягким сиденьем. Материал: деревянный каркас, ткань. Цвет: серый.", "Стул.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Письменный стол c полкой. Материал: ЛДСП. Цвет: Белый. Размеры: 100х60х75 см.", "Письменныйстол.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Диван, 2 кресла, журнальный столик. Материал: ткань, ЛДСП. Цвет: бежевый.", "ГостинаяМодель1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Угловой диван, столик, ТВ-тумба. Материал: ткань, ЛДСП. Цвет: серый.", "Гостинаямодель2.jpg" });
        }
    }
}
