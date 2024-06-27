using PlayFolioShelf.Data;
using PlayFolioShelf.Data.Entities;
using PlayFolioShelf.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PlayFolioShelf.Services.Services
{
    // the implementation of the user review related shit

    public class UserReviewService : IUserReviewService
    {
        // priv readonly field to hold the context instance

        private readonly PlayFolioShelfContext _context;

        // constructor initializes the context via dependency injection

        public UserReviewService(PlayFolioShelfContext context)
        {
            _context = context;
        }

        // get all user reviews from the db

        public IEnumerable<UserReview> GetAllUserReviews() => _context.UserReviews.ToList();

        // get a user review by its ID

        public UserReview GetUserReviewById(int id) => _context.UserReviews.Find(id);

        // create a new user review

        public void CreateUserReview(UserReview userReview)
        {
            // add the new user review to the context
            _context.UserReviews.Add(userReview);
            // save changes to the db
            _context.SaveChanges();
        }

        // update an existing user review

        public void UpdateUserReview(UserReview userReview)
        {
            // update the user review in the context
            _context.UserReviews.Update(userReview);
            // save changes to the database
            _context.SaveChanges();
        }

        // For when delete a user review by its ID

        public void DeleteUserReview(int id)
        {
            // Find a user review by its ID

            var userReview = _context.UserReviews.Find(id);
            if (userReview != null)
            {
                // removes the user's review from the context

                _context.UserReviews.Remove(userReview);
                // To save changes to the db
                _context.SaveChanges();
            }
        }
    }
}
