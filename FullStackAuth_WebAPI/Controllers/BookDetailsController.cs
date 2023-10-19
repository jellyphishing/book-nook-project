using FullStackAuth_WebAPI.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FullStackAuth_WebAPI.DataTransferObjects;
using FullStackAuth_WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;




namespace FullStackAuth_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookDetailsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BookDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("{bookId}")]
        public IActionResult GetBookDetails(string bookId)
        {

            var bookReviews = _context.Reviews.Where(r => r.BookId.Equals(bookId)).Include(r => r.User).Select(r => new ReviewWithUserDto
            {
                Id= r.Id,
                BookId = bookId,
                Text = r.Text,
                Rating = r.Rating,
                User = new UserForDisplayDto
                {
                    Id=r.User.Id,
                    FirstName = r.User.FirstName,
                    LastName = r.User.LastName,
                    UserName= r.User.UserName,  
                }
            }).ToList(); 

            var averageRating = bookReviews.Average(r => r.Rating);

            string userId = User.FindFirstValue("id");
            var userBookFavorites = _context.Favorites.Where(f => f.UserId.Equals(userId) && f.BookId.Equals(bookId));

            var isFavorited = false;
            if (userBookFavorites.Any()) 
            {
                isFavorited = true;
            }

            var bookDetails = new BookDetailsDto
            {

                AverageRating = averageRating,
                IsFavorited = isFavorited,
                Reviews = bookReviews
            };


            return StatusCode(200, bookDetails );
        }



    }
}