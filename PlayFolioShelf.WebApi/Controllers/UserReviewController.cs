using Microsoft.AspNetCore.Mvc;
using PlayFolioShelf.Models;
using PlayFolioShelf.Services;
using PlayFolioShelf.Data;
using PlayFolioShelf.Services.Interfaces;


namespace PlayFolioShelf.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserReviewController : ControllerBase
    {
        private readonly IUserReviewService _userReviewService;

        public UserReviewController(IUserReviewService userReviewService)
        {
            _userReviewService = userReviewService;
        }

        // This method handles GET requests and returns a list of all user reviews.
        [HttpGet]
        public IActionResult GetAllUserReviews()
        {
            return Ok(_userReviewService.GetAllUserReviews());
        }

        // This method handles GET requests with an ID and returns a specific user review by its ID.
        [HttpGet("{id}")]
        public IActionResult GetUserReviewById(int id)
        {
            return Ok(_userReviewService.GetUserReviewById(id));
        }

        // This method handles POST requests and creates a new user review.
        [HttpPost]
        public IActionResult CreateUserReview([FromBody] UserReview userReview)
        {
            _userReviewService.CreateUserReview(userReview);
            return CreatedAtAction(nameof(GetUserReviewById), new { id = userReview.UserReviewId }, userReview);
        }

        // This method handles PUT requests and updates an existing user review.
        [HttpPut("{id}")]
        public IActionResult UpdateUserReview(int id, [FromBody] UserReview userReview)
        {
            // If the ID in the URL does not match the ID in the request body, return a Bad Request response.
            if (id != userReview.UserReviewId)
            {
                return BadRequest();
            }
            _userReviewService.UpdateUserReview(userReview);
            return NoContent();
        }

        // This method handles DELETE requests and deletes a user review by its ID.
        [HttpDelete("{id}")]
        public IActionResult DeleteUserReview(int id)
        {
            _userReviewService.DeleteUserReview(id);
            return NoContent();
        }
    }
}
