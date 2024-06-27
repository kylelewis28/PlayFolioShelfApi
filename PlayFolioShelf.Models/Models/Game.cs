namespace PlayFolioShelf.Models.Models;

public class Game

{
    public int Id { get; set; }
    public string? Title { get; set; }//"?" = null//

    public string? Genre { get; set; }

    public int MaturityId { get; set; }

    public virtual List<UserReview> UserReviews {get ; set;} 

}
