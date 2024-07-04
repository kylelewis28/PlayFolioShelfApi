using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PlayFolioShelf.Models;
using PlayFolioShelf.Data.Entities;

namespace PlayFolioShelf.Data
{
    public class PlayFolioShelfContext : IdentityDbContext<UserEntity, IdentityRole<int>, int>
    {
        public PlayFolioShelfContext(DbContextOptions<PlayFolioShelfContext> options)
            : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity>().ToTable("Users");
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<UserReview> UserReviews { get; set; }
        public DbSet<MaturityRating> MaturityRatings { get; set; }
    }
}
