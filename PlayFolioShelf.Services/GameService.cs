using System.Collections.Generic;
using System.Linq;
using PlayFolioShelf.Data;
using PlayFolioShelf.Models; // Add the correct namespace for Game

namespace PlayFolioShelf.Services.Services
{
    public class GameService : IGameService
    {
        private readonly PlayFolioShelfContext _context; 

        public GameService(PlayFolioShelfContext context) 
        {
            _context = context;
        }

        public IEnumerable<Game> GetAllGames() => _context.Games.ToList(); 

        public Game GetGameById(int id) => _context.Games.Find(id); 

        public void CreateGame(Game game) 
        {
            _context.Games.Add(game);
            _context.SaveChanges(); 
        }

        public void UpdateGame(Game game) 
        {
            _context.Games.UpdateRange(game); 
            _context.SaveChanges(); 
        }

        public void DeleteGame(int id) 
        {
            var game = _context.Games.Find(id); 
            if (game != null) 
            {
                _context.Games.Remove(game); 
                _context.SaveChanges(); 
            }
        }
    }
}
