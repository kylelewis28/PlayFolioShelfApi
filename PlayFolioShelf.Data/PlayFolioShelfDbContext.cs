using PlayFolioShelf.Data;
using Microsoft.EntityFrameworkCore;
using PlayFolioShelf.Models.Models;

namespace PlayFolioShelf.Data
{
    public class PlayFolioShelfContext : DbContext  // DbContext class for the PlayfolioShelf application
    {
        public PlayFolioShelfContext(DbContextOptions<PlayFolioShelfContext> options) : base(options) { } // Constructor that takes DbContextOptions and passes it to the base DbContext class

        public DbSet<Game> Games { get; set; }                  // DbSet representing the Games table
        public DbSet<UserReview> UserReviews { get; set; }   	 // DbSet representing the UserReviews table

        public DbSet<MaturityRating> MaturityRatings { get; set; }
    }
}


