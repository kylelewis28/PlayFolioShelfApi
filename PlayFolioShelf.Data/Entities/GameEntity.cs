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
        public string Title { get; set; }

        [Required]
        [ForeignKey(nameof(MaturityRating))]     //!Use annotations instead of messing with PlayfolioContext
        public int MaturityRatingId { get; set; } // Foreign key to MaturityRating
        
        [MaxLength(50)]
        public string? Genre { get; set; }

        // Navigation property to MaturityRating

        public virtual MaturityRating MaturityRating { get; set; }

        // Navigation property to UserReviews
        public virtual ICollection<UserReview> UserReviews { get; set; } = new List<UserReview>();
    }
}
