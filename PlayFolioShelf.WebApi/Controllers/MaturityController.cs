using Microsoft.AspNetCore.Mvc;
using PlayFolioShelf.Models;
using PlayFolioShelf.Services;
using PlayFolioShelf.Services.Services;
using PlayFolioShelf.Data;


namespace PlayFolioShelf.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MaturityController : ControllerBase
    {
        private readonly IMaturityService _maturityService;

        public MaturityController(IMaturityService maturityService)
        {
            _maturityService = maturityService;
        }

        // This method responds to GET requests and returns a list of all maturity s
        [HttpGet]
        public IActionResult GetAllMaturityRatings()
        {
            return Ok(_maturityService.GetAllMaturityRatings());
        }

        // This method responds to GET requests with an ID and returns a specific maturity  by its ID
        [HttpGet("{id}")]
        public IActionResult GetMaturityRatingById(int id)
        {
            return Ok(_maturityService.GetMaturityRatingById(id));
        }

        // This method responds to POST requests and creates a new maturity 
        [HttpPost]
        public IActionResult CreateMaturityRating([FromBody] MaturityRating maturityRating)
        {
            _maturityService.CreateMaturityRating(maturityRating);
            return CreatedAtAction(nameof(GetMaturityRatingById), new { id = maturityRating.Id }, maturityRating);
        }

        // This method responds to PUT requests and updates an existing maturity 
        [HttpPut("{id}")]
        public IActionResult UpdateMaturityRating(int id, [FromBody] MaturityRating maturityRating)
        {
            // If the ID in the URL does not match the ID in the request body, return a Bad Request response
            if (id != maturityRating.Id)
            {
                return BadRequest();
            }
            _maturityService.UpdateMaturityRating(maturityRating);
            return NoContent();
        }

        // This method responds to DELETE requests and deletes a maturity  by its ID
        [HttpDelete("{id}")]
        public IActionResult DeleteMaturityRating(int id)
        {
            _maturityService.DeleteMaturityRating(id);
            return NoContent();
        }
    }
}
