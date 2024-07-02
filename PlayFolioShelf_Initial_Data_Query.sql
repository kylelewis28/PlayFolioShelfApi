-- Enable IDENTITY_INSERT for MaturityRatings
SET IDENTITY_INSERT MaturityRatings ON;

INSERT INTO MaturityRatings (MaturityRatingId, EsrbRating, Description)
VALUES (1, 'E', 'Everyone');
INSERT INTO MaturityRatings (MaturityRatingId, EsrbRating, Description)
VALUES (2, 'M', 'Mature');

-- Disable IDENTITY_INSERT for MaturityRatings
SET IDENTITY_INSERT MaturityRatings OFF;

-- Enable IDENTITY_INSERT for Games
SET IDENTITY_INSERT Games ON;

INSERT INTO Games (Id, Title, Genre, MaturityRatingId)
VALUES (1, 'Pokemon', 'RPG', 1);
INSERT INTO Games (Id, Title, Genre, MaturityRatingId)
VALUES (2, 'Persona 5 Royal', 'JRPG', 2);
INSERT INTO Games (Id, Title, Genre, MaturityRatingId)
VALUES (3, 'The Legend of Zelda: Link''s Awakening', 'Action-Adventure', 1);

-- Disable IDENTITY_INSERT for Games
SET IDENTITY_INSERT Games OFF;

-- Enable IDENTITY_INSERT for UserReviews
SET IDENTITY_INSERT UserReviews ON;

INSERT INTO UserReviews (UserReviewId, GameId, UserId, Rating, Review)
VALUES (1, 1, 'crispycloud3', 4.0, 'Awesome game, could use more character development');
INSERT INTO UserReviews (UserReviewId, GameId, UserId, Rating, Review)
VALUES (2, 2, 'CountVoRiagan', 9.0, 'Dark themes, great gameplay, long to complete but entirely worth it!');
INSERT INTO UserReviews (UserReviewId, GameId, UserId, Rating, Review)
VALUES (3, 3, 'TanManGames', 9.2, 'One of the best of all time! Highly recommended.');

-- Disable IDENTITY_INSERT for UserReviews
SET IDENTITY_INSERT UserReviews OFF;
