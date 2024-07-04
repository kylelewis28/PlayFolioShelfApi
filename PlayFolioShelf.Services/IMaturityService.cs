using PlayFolioShelf.Models;

namespace PlayFolioShelf.Services.Services 
{
    public interface IMaturityService 
    {
        IEnumerable<MaturityRating> GetAllMaturityRatings(); 

        MaturityRating GetMaturityRatingById(int id);

        void CreateMaturityRating(MaturityRating maturityRating);

        void UpdateMaturityRating(MaturityRating maturityRating);

        void DeleteMaturityRating(int id);
    }
}