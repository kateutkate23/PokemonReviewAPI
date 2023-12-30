using PokemonReviewAPI.Models;

namespace PokemonReviewAPI.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetAllReviews();
        Review GetReview(int reviewerId);
        ICollection<Review> GetReviewsOfAPokemon(int pokemonId);
        bool ReviewExists(int reviewId);
        bool CreateReview(Review review);
        bool UpdateReview(Review review);
        bool DeleteReview(Review review);
        bool DeleteReviews(List<Review> reviews);
        bool Save();
    }
}
