using PlayFolioShelf.Data;
using PlayFolioShelf.Services.Services;
using PlayFolioShelf.Models;

namespace PlayFolioShelf.Services.Services
{
    public class MaturityRatingService : IMaturityRatingService
    {
        private readonly PlayFolioShelfContext _context;
        public MaturityRatingService(PlayFolioShelfContext context)
        {
            _context = context;
        }
        public void CreateMaturityRating(MaturityRating maturityRating)
        {
            _context.MaturityRating.Add(maturityRating);
            _context.SaveChanges();
        }

        public void DeleteMaturityRating(MaturityRating maturityRating)
        {
            var maturityRating = _context.MaturityRating.Find(id);
            if (maturityRating != null)
            {
                _context.MaturityRating.Remove(maturityRating);
                _context.SaveChanges();
            }
        }

        public IEnumerable<MaturityRating> GetAllMaturityRating()
        {
            return _context.MaturityRating.ToList();
        }

        public MaturityRating GetMaturityRatingById(int id)
        {
            return _context.MaturityRating.Find(id);
        }

        public void UpdateMaturityRating(MaturityRating maturityRating)
        {
            _context.MaturityRating.Update(maturityRating);
            _context.SaveChanges();
        }
    }
}