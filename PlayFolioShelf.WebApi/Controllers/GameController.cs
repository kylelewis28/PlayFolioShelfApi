using Microsoft.AspNetCore.Mvc;
using PlayFolioShelf.Models;
using PlayFolioShelf.Services;
using PlayFolioShelf.Services.Services;
using PlayFolioShelf.Data;

namespace PlayFolioShelf.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService; // Service dependency for game operations

        // Constructor to initialize the controller with an IGameService instance
        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        // GET api/game
        // Retrieves all games
        [HttpGet]
        public IActionResult GetAllGames()
        {
            return Ok(_gameService.GetAllGames());
        }

        // GET api/game/{id}
        // Retrieves a specific game by its ID
        [HttpGet("{id}")]
        public IActionResult GetGameById(int id)
        {
            return Ok(_gameService.GetGameById(id));
        }

        // POST api/game
        // Creates a new game
        [HttpPost]
        public IActionResult CreateGame([FromBody] Game game)
        {
            _gameService.CreateGame(game); // Invokes the service method to add a new game to the database
            return CreatedAtAction(nameof(GetGameById), new { id = game.Id }, game); // Returns HTTP 201 with the newly created game's ID
        }

        // PUT api/game/{id}
        // Updates an existing game
        [HttpPut("{id}")]
        public IActionResult UpdateGame(int id, [FromBody] Game game)
        {
            if (id != game.Id)
            {
                return BadRequest(); // Returns HTTP 400 if the provided ID in the URL does not match the game's ID in the body
            }
            _gameService.UpdateGame(game); // Invokes the service method to update the game
            return NoContent(); // Returns HTTP 204 indicating successful update with no content
        }

        // DELETE api/game/{id}
        // Deletes a game by its ID
        [HttpDelete("{id}")]
        public IActionResult DeleteGame(int id)
        {
            _gameService.DeleteGame(id); // Invokes the service method to delete the game by ID
            return NoContent(); // Returns HTTP 204 indicating successful deletion with no content
        }
    }
}
