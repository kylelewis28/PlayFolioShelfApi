using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using PlayFolioShelf.Models;


namespace PlayFolioShelf.Data.Entities
{
    public class MaturityRatingEntity
    {
        [Key]
        public int MaturityRatingId { get; set; }

        [MaxLength(10)]
        public string? EsrbRating { get; set; }

        [MaxLength(500)]
        public string? MaturityDescription { get; set; }

        public virtual ICollection<Game> Games { get; set; } = new List<Game>(); // Navigation property
    }
}
