using PlayFolioShelf.Data;
using PlayFolioShelf.Services.Services;
using PlayFolioShelf.Models;

namespace PlayFolioShelf.Services.Services 
{
    public class MaturityRatingService : IMaturityRatingService
    {
        private readonly PlayFolioShelfContext _context;

        public void CreateMaturityRating(MaturityRating maturityRating)
        {
            throw new NotImplementedException();
        }

        public void DeleteMaturityRating(MaturityRating maturityRating)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MaturityRating> GetAllMaturityRating()
        {
            throw new NotImplementedException();
        }

        public MaturityRating GetMaturityRatingById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateMaturityRating(MaturityRating maturityRating)
        {
            throw new NotImplementedException();
        }
    public MaturityRatingService(PlayFolioShelfContext context) 
    {
        _context = context; 
    }
    } 

}