using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InteriorCenterBackend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Stock = table.Column<int>(type: "integer", nullable: false),
                    ImageUrl = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    FullName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "ImageUrl", "Name", "Price", "Stock", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc), "", "https://interior-center.ru/wp-content/uploads/2024/06/1.jpg", "Кухня Модель 1", 15000m, 5, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc), "", "https://interior-center.ru/wp-content/uploads/2024/06/3-1.jpg", "Кухня Модель 2", 18000m, 3, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc), "", "https://interior-center.ru/wp-content/uploads/2024/06/3.jpg", "Модульная кухня", 22000m, 2, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc), "", "https://interior-center.ru/wp-content/uploads/2024/06/3.jpg", "Кровать", 12000m, 8, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc), "", "https://interior-center.ru/wp-content/uploads/2024/06/27.jpg", "Комод", 8000m, 10, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc), "", "https://interior-center.ru/wp-content/uploads/2025/02/СТП06-1200_Белый.jpg", "Письменный стол", 6500m, 9, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc), "", "https://interior-center.ru/wp-content/uploads/2024/06/1-1.jpg", "Диван", 25000m, 4, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc), "", "https://interior-center.ru/wp-content/uploads/2024/06/1-2.jpg", "Тумба под ТВ", 7000m, 12, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc), "", "https://interior-center.ru/wp-content/uploads/2024/06/1-3.jpg", "Стол обеденный", 9000m, 6, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc), "", "https://interior-center.ru/wp-content/uploads/2024/06/1-4.jpg", "Стул", 2500m, 20, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 11, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc), "", "https://interior-center.ru/wp-content/uploads/2024/06/1-5.jpg", "Шкаф", 15000m, 7, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 12, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc), "", "https://interior-center.ru/wp-content/uploads/2024/06/1-6.jpg", "Прихожая", 18000m, 5, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 13, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc), "", "https://interior-center.ru/wp-content/uploads/2024/06/1-7.jpg", "Книжный шкаф", 10000m, 8, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 14, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc), "", "https://interior-center.ru/wp-content/uploads/2024/06/1-8.jpg", "Кресло", 5000m, 15, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 15, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc), "", "https://interior-center.ru/wp-content/uploads/2024/06/1-9.jpg", "Журнальный столик", 3500m, 10, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 16, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc), "", "https://interior-center.ru/wp-content/uploads/2024/06/1-10.jpg", "Кухонный гарнитур", 28000m, 3, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 17, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc), "", "https://interior-center.ru/wp-content/uploads/2024/06/1.jpg", "Гостиная Модель 1", 45000m, 2, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 18, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc), "", "https://interior-center.ru/wp-content/uploads/2025/04/Spalnya_4_4-scaled.jpg", "Гостиная с угловым диваном", 52000m, 1, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 19, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc), "", "https://interior-center.ru/wp-content/uploads/2024/06/1-11.jpg", "Спальня Модель 1", 35000m, 4, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 20, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc), "", "https://interior-center.ru/wp-content/uploads/2024/06/1-12.jpg", "Спальня Модель 2", 40000m, 3, new DateTime(2025, 11, 20, 10, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
