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

    }

}



