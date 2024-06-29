using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PlayFolioShelf.Models;


namespace PlayFolioShelf.Data.Entities
{
    public class GameEntity
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [ForeignKey(nameof(MaturityRating))]     //!Use annotations instead of messing with PlayfolioContext
        public int MaturityRatingId { get; set; } // Foreign key to MaturityRating
        
        [Required][MaxLength(50)]
        public string? Genre { get; set; } = string.Empty;

        // Navigation property to MaturityRating
        [Required]

        public virtual MaturityRating MaturityRating { get; set; } = new MaturityRatingEntity();

        // Navigation property to UserReviews
        
        public virtual ICollection<UserReview> UserReviews { get; set; } = new List<UserReview>();
    }
}
