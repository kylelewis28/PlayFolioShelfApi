using PlayFolioShelf.Models;
using System.Collections.Generic;

namespace PlayFolioShelf.Services.Interfaces
{
    public interface IUserReviewService
    {
    IEnumerable<UserReview> GetAllUserReviews();

    UserReview GetUserReviewById(int ID);

    void CreateUserReview(UserReview userReview);

    void UpdateUserReview(UserReview userReview);

    void DeleteUserReview(int Id);
    }
}