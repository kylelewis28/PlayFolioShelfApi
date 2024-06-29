using PlayFolioShelf.Data;
using Microsoft.EntityFrameworkCore;
using PlayFolioShelf.Models;
using PlayFolioShelf.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace PlayFolioShelf.Data
{
    public class PlayFolioShelfContext : IdentityDbContext<UserEntity, IdentityRole<int>, int>   // DbContext class for the PlayFolioShelf application
    {
        public PlayFolioShelfContext(DbContextOptions<PlayFolioShelfContext> options)
        
             : base(options) { } // Constructor that takes DbContextOptions and passes it to the base DbContext class

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity>().ToTable("Users");
        }

        public DbSet<Game> Games { get; set; }                  // DbSet representing the Games table
        public DbSet<UserReview> UserReviews { get; set; }   	 // DbSet representing the UserReviews table

        public DbSet<MaturityRating> MaturityRatings { get; set; }
    }
}


