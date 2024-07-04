using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlayFolioShelf.Models
{
    public class Game
    {
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; } = string.Empty;
        
        [Required]
        public string Genre { get; set; } = string.Empty;
        
        public int MaturityRatingId { get; set; }
        
        [Required]
        public MaturityRating MaturityRating { get; set; } = new MaturityRating();
        
        public virtual ICollection<UserReview> UserReviews { get; set; } = new List<UserReview>();
    }
}
