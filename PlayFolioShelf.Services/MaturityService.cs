using PlayFolioShelf.Data;
using PlayFolioShelf.Models;
using System.Collections.Generic;
using System.Linq;

namespace PlayFolioShelf.Services.Services
{
    public class MaturityService : IMaturityService
    {
        private readonly PlayFolioShelfContext _context;

        public MaturityService(PlayFolioShelfContext context)
        {
            _context = context;
        }

        public IEnumerable<MaturityRating> GetAllMaturityRatings()
        {
            return _context.MaturityRatings.ToList();
        }

        public MaturityRating GetMaturityRatingById(int id)
        {
            return _context.MaturityRatings.Find(id);
        }

        public void CreateMaturityRating(MaturityRating maturityRating)
        {
            _context.MaturityRatings.Add(maturityRating);
            _context.SaveChanges();
        }

        public void UpdateMaturityRating(MaturityRating maturityRating)
        {
            _context.MaturityRatings.Update(maturityRating);
            _context.SaveChanges();
        }

        public void DeleteMaturityRating(int id)
        {
            var maturityRating = _context.MaturityRatings.Find(id);
            if (maturityRating != null)
            {
                _context.MaturityRatings.Remove(maturityRating);
                _context.SaveChanges();
            }
        }
    }
}
