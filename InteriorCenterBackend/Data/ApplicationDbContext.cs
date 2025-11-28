// Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using InteriorCenterBackend.Models;

namespace InteriorCenterBackend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderItem> OrderItems { get; set; } = null!;

        public DbSet<Picture> Pictures { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne()
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<OrderItem>()
            // .HasOne(oi => oi.Order)
            // .WithMany(o => o.OrderItems)
            // .HasForeignKey(oi => oi.OrderId)
            // .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(oi => oi.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Кухня Модель 1",
                    Price = 15000,
                    Stock = 5,
                    ImageUrl = "Pic/КухняМодель1.jpg",
                    Description = "Компактный кухонный гарнитур для небольшой кухни. Материал: ЛДСП. Цвет: Белый. Размеры: 200х100х80 см.",
                    CreatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc)
                },
                new Product
                {
                    Id = 2,
                    Name = "Кухня Модель 2",
                    Price = 18000,
                    Stock = 3,
                    ImageUrl = "Pic/КухняМодель2.jpg",
                    Description = "Угловая кухня с вместительными шкафами. Материал: ЛДСП. Цвет: Бежевый. Размеры: 250х150х80 см.",
                    CreatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc)
                },
                new Product
                {
                    Id = 3,
                    Name = "Модульная кухня",
                    Price = 22000,
                    Stock = 2,
                    ImageUrl = "Pic/Модульнаякухня.jpg",
                    Description = "Гибкая система, которую можно адаптировать под любую планировку. Материал: ЛДСП. Цвета: на выбор.",
                    CreatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc)
                },
                new Product
                {
                    Id = 4,
                    Name = "Кухня с островом",
                    Price = 32000,
                    Stock = 8,
                    ImageUrl = "Pic/КухняCOстровом.jpg",
                    Description = "Просторная кухня с островом для готовки и хранения. Материал: ЛДСП. Цвет: Серый/Белый. Размеры: 300х200х80 см.",
                    CreatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc)
                },
                new Product
                {
                    Id = 5,
                    Name = "Спальня Модель 1",
                    Price = 25000,
                    Stock = 10,
                    ImageUrl = "Pic/СпальняМодель1.jpg",
                    Description = "Уютный комплект из кровати, тумбочек и шкафа. Материал - ЛДСП. Цвет - Белый/Серый. Идеально подходит для молодой семьи.",
                    CreatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc)
                },
                new Product
                {
                    Id = 6,
                    Name = "Модульная спальня",
                    Price = 30000,
                    Stock = 9,
                    ImageUrl = "Pic/Модульнаяспальн.jpg",
                    Description = "Просторный гарнитур с изголовьем кровати, прикроватными тумбами, комодом и шкафом-купе. Материал - массив сосны. Цвет - Орех.",
                    CreatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc)
                },
                new Product
                {
                    Id = 7,
                    Name = "Кровать ортопедическая",
                    Price = 12000,
                    Stock = 4,
                    ImageUrl = "Pic/КроватьОртопедическая.jpg",
                    Description = "Удобная и прочная конструкция с ортопедическим основанием. Различные размеры и варианты обивки.",
                    CreatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc)
                },
                new Product
                {
                    Id = 8,
                    Name = "Спальня с балдахином",
                    Price = 35000,
                    Stock = 12,
                    ImageUrl = "Pic/Спальнясбалдахином.jpg",
                    Description = "Роскошная спальня с балдахином и полным комплектом мебели. Материал: ЛДСП, ткань. Цвет: Бежевый. Создаст романтичную атмосферу.",
                    CreatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc)
                },
                new Product
                {
                    Id = 9,
                    Name = "Молодежная Модель 1",
                    Price = 18000,
                    Stock = 6,
                    ImageUrl = "Pic/МолодежнаяМодель1.jpg",
                    Description = "Яркий и функциональный комплект для подростковой комнаты. Включает кровать, письменный стол, шкаф и полки. Материал - ЛДСП. Цвет - Белый/Голубой. Много места для хранения и учебы.",
                    CreatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc)
                },
                new Product
                {
                    Id = 10,
                    Name = "Модульная молодежная",
                    Price = 24000,
                    Stock = 20,
                    ImageUrl = "Pic/Модульнаямолодежная.jpg",
                    Description = "Гибкая система мебели, которую можно адаптировать под рост и предпочтения ребенка. Многофункциональные элементы. Материал - ЛДСП. Цвета - на выбор. Возможна индивидуальная сборка.",
                    CreatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc)
                },
                new Product
                {
                    Id = 11,
                    Name = "Ронда",
                    Price = 22000,
                    Stock = 7,
                    ImageUrl = "Pic/Ронда.jpg",
                    Description = "Современный комплект с интересным дизайном. Включает кровать, письменный стол, шкаф и полки. Материал - ЛДСП. Цвет - Крафт-серый. Удобно и стильно. Молодежно. Красиво",
                    CreatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc)
                },
                new Product
                {
                    Id = 12,
                    Name = "Молодежная с рабочей зоной",
                    Price = 20000,
                    Stock = 5,
                    ImageUrl = "Pic/Молодежнаясрабочейзоной.jpg",
                    Description = "Комплект, включающий удобную кровать и полноценную рабочую зону с полками. Материал - ЛДСП. Цвет - Белый/Серый. Отличное решение для школьника или студента.",
                    CreatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc)
                },
                new Product
                {
                    Id = 13,
                    Name = "Комод",
                    Price = 8000,
                    Stock = 8,
                    ImageUrl = "Pic/Комод.jpg",
                    Description = "Вместительный комод с 4 ящиками для хранения постельного белья, одежды и мелочей. Материал - ЛДСП. Цвет - Белый. Размеры: 80х40х90 см. Классический дизайн.",
                    CreatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc)
                },
                new Product
                {
                    Id = 14,
                    Name = "Стеллаж",
                    Price = 5000,
                    Stock = 15,
                    ImageUrl = "Pic/Стеллаж.jpg",
                    Description = "Открытая конструкция для книг, декоративных предметов и игрушек. Материал - ЛДСП. Цвет - Бук. Размеры: 100х30х180 см. Современный классный дизайн.",
                    CreatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc)
                },
                new Product
                {
                    Id = 15,
                    Name = "Шкаф купе",
                    Price = 15000,
                    Stock = 3,
                    ImageUrl = "Pic/Шкафкупе.jpg",
                    Description = "Вместительный шкаф купе с 3 дверями. Материал - ЛДСП. Цвет - Белый/Зеркало. Размеры: 200х60х220 см. Отличное решение для хранения одежды и обуви.",
                    CreatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc)
                },
                new Product
                {
                    Id = 16,
                    Name = "Стол",
                    Price = 7000,
                    Stock = 10,
                    ImageUrl = "Pic/Стол.jpg",
                    Description = "Обеденный стол из прочного ЛДСП. Доступны различные размеры и цвета столешницы. Каркас - металл. Размеры: 120х80 см. Подходит для 4-6 человек.",
                    CreatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc)
                },
                new Product
                {
                    Id = 17,
                    Name = "Стул",
                    Price = 2500,
                    Stock = 12,
                    ImageUrl = "Pic/Стул.jpg",
                    Description = "Удобный стул с мягким сиденьем и деревянным каркасом. Материал сиденья - ткань. Цвет - серый. Идеально подходит для кухни",
                    CreatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc)
                },
                new Product
                {
                    Id = 18,
                    Name = "Письменный стол",
                    Price = 6500,
                    Stock = 9,
                    ImageUrl = "Pic/Письменныйстол.jpg",
                    Description = "Удобный стол для работы или учебы с дополнительной полкой для книг и канцелярии. Материал - ЛДСП. Цвет - Белый. Размеры: 100х60х75 см.",
                    CreatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc)
                },
                new Product
                {
                    Id = 19,
                    Name = "Гостиная Модель 1",
                    Price = 45000,
                    Stock = 2,
                    ImageUrl = "Pic/ГостинаяМодель1.jpg",
                    Description = "Удобный комплект для гостиной, включающий диван, 2 кресла и журнальный столик. Материал обивки - ткань. Материал столика - ЛДСП. Цвет - бежевый. Создаст уютную атмосферу.",
                    CreatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc)
                },
                new Product
                {
                    Id = 20,
                    Name = "Гостиная модель 2",
                    Price = 52000,
                    Stock = 1,
                    ImageUrl = "Pic/Гостинаямодель2.jpg",
                    Description = "Просторная гостиная с угловым диваном, обеспечивающим комфорт для большого количества людей.Материал - ткань, ЛДСП. Цвет - серый.",
                    CreatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 11, 20, 10, 0, 0, DateTimeKind.Utc)
                }
            );

            modelBuilder.Entity<Picture>().HasData(
                new Picture
                {
                    Id = 1,
                    ImageUrL = "Pic/1.jpg",
                    Title = "Стильные кухни",
                    Description = "Широкий выбор кухонных гарнитуров на любой вкус"
                },
                new Picture
                {
                    Id = 2,
                    ImageUrL = "Pic/2.jpg",
                    Title = "Уютные спальни",
                    Description = "Создайте идеальное место для отдыха"
                },
                new Picture
                {
                    Id = 3,
                    ImageUrL = "Pic/3.jpg",
                    Title = "Молодежные коллекции",
                    Description = "Современные решения для детской комнаты"
                },
                new Picture
                {
                    Id = 4,
                    ImageUrL = "Pic/4.jpg",
                    Title = "Системы хранения",
                    Description = "Организуйте пространство с умом"
                },
                new Picture
                {
                    Id = 5,
                    ImageUrL = "Pic/5.jpg",
                    Title = "Столы и стулья",
                    Description = "Для уютных семейных обедов"
                }
            );
        }
    }
}