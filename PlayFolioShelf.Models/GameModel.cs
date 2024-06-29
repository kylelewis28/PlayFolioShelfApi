namespace PlayFolioShelf.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int MaturityRatingId { get; set; }
        public string Genre { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public List<UserReview> UserReviews { get; set; } = new List<UserReview>();
    }
}
