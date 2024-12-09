using System.Collections.Generic;
using PlayFolioShelf.Models; 

namespace PlayFolioShelf.Services.Services
{
    public interface IGameService
    {
        IEnumerable<Game> GetAllGames(); // retrieves a list of all games.
        Game GetGameById(int id); // retrieves a specific game by its ID.
        void CreateGame(Game game); // adds a new game to the system.
        void UpdateGame(Game game); // updates an existing game.
        void DeleteGame(int id); // deletes a game based on its ID.
    }
}
