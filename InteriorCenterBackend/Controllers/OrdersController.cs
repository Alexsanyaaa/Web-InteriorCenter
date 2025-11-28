using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InteriorCenterBackend.Data;
using InteriorCenterBackend.Models;
using System.Security.Claims; // ← ДОБАВЬТЕ ЭТО!

namespace InteriorCenterBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Order>> CreateOrder([FromBody] CreateOrderModel model)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userIdClaim))
            {
                Console.WriteLine("Ошибка: UserIdClaim пустой или null");
                return Unauthorized("Не удалось извлечь ID пользователя из токена.");
            }

            var userId = int.Parse(userIdClaim);

            var order = new Order
            {
                UserId = userId,
                Status = "Pending",
                TotalAmount = model.TotalAmount
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            foreach (var item in model.Items)
            {
                var product = await _context.Products.FindAsync(item.ProductId);
                if (product == null)
                {
                    return BadRequest($"Продукт с ID {item.ProductId} не найден.");
                }

                if (product.Stock < item.Quantity)
                {
                    return BadRequest($"Недостаточно товара '{product.Name}' на складе.");
                }

                var orderItem = new OrderItem
                {
                    OrderId = order.Id,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    UnitPrice = product.Price
                };

                _context.OrderItems.Add(orderItem);

                product.Stock -= item.Quantity;
            }

            await _context.SaveChangesAsync();

            await _context.Entry(order)
                .Collection(o => o.OrderItems)
                .LoadAsync();

            return CreatedAtAction(nameof(GetOrder), new { id = order.Id }, order);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = await _context.Orders
                .Include(o => o.User)
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Product)
                .FirstOrDefaultAsync(o => o.Id == id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }
    }

    public class CreateOrderModel
    {
        public decimal TotalAmount { get; set; }
        public List<OrderItemModel> Items { get; set; } = new List<OrderItemModel>();
    }

    public class OrderItemModel
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}