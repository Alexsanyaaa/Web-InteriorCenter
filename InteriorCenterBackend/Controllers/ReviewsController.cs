// Controllers/ReviewsController.cs
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InteriorCenterBackend.Data;
using InteriorCenterBackend.Models;
using System.Security.Claims;
namespace InteriorCenterBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ReviewsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Review>>> GetAllReviews()
        {
            var reviews = await _context.Reviews
                .Include(r => r.User)
                .OrderByDescending(r => r.CreatedAt)
                .ToListAsync();

            return Ok(reviews);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Review>> CreateReview([FromBody] CreateReviewModel model)
        {
            var claims = User.Claims.ToList();
            Console.WriteLine("Количество claims: " + claims.Count);
            foreach (var claim in claims)
            {
                Console.WriteLine($"{claim.Type}: {claim.Value}");
            }

            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userIdClaim == null)
            {
                return Unauthorized();
            }

            var userId = int.Parse(userIdClaim);

            var review = new Review
            {
                UserId = userId,
                AuthorName = model.AuthorName,
                Content = model.Content,
                CreatedAt = DateTime.UtcNow
            };

            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();

            //await _context.Entry(review)
            //    .Reference(r => r.User)
            //    .LoadAsync();

            return CreatedAtAction(nameof(GetAllReviews), new { }, review);
        }
    }

    public class CreateReviewModel
    {
        public string Content { get; set; } = string.Empty;
        public string? AuthorName { get; set; }
        public int UserId { get; set; }
    }
}