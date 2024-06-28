using PlayFolioShelf.Models;

namespace PlayFolioShelf.Services.Services 
{
    public interface IMaturityRatingService 
    {
        IEnumerable<MaturityRating> GetAllMaturityRating(); 

        MaturityRating GetMaturityRatingById(int id);

        void CreateMaturityRating(MaturityRating maturityRating);

        void UpdateMaturityRating(MaturityRating maturityRating);

        void DeleteMaturityRating(MaturityRating maturityRating) ;
    }
}