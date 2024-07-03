using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace PlayFolioShelf.Models
{
    public class UserReview
    {
        public int UserReviewId {get; set;}       //Primary key for UserReview
        public int GameId { get; set; }     //FK to Games table
        public string? UserId { get; set; }      //Identifier for user's review (username or something) also FK
        public double Rating { get; set; }      //Numerical rating
        public string? Review { get; set; }     //Written Review
        public virtual required Game Game { get; set; }      //Nav to related 'Game' entity (revisit after Game.cs)
    }
}