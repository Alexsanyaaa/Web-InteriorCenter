using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InteriorCenterBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddTitleAndDescriptionToPicture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Pictures",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Pictures",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Широкий выбор кухонных гарнитуров на любой вкус", "Стильные кухни" });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Создайте идеальное место для отдыха", "Уютные спальни" });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Современные решения для детской комнаты", "Молодежные коллекции" });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Организуйте пространство с умом", "Системы хранения" });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Для уютных семейных обедов", "Столы и стулья" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Pictures");
        }
    }
}
