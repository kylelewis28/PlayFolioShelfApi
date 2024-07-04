using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using PlayFolioShelf.Models;


namespace PlayFolioShelf.Data.Entities
{
    public class UserReviewEntity
    {
        [Key]
        public int UserReviewId { get; set; }

        [Required]
        [ForeignKey(nameof(Game))]
        public int GameId { get; set; } // Foreign key to Game

        [MaxLength(50)]
        public string? UserId { get; set; }

        [Range(1, 10)]
        public int Rating { get; set; }

        [MaxLength(1000)]
        public string? Review { get; set; }

        [ForeignKey("GameId")]
        public virtual required Game Game { get; set; } // Navigation property
    }
}
