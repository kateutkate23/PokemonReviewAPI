using PokemonReviewAPI.Models;

namespace PokemonReviewAPI.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetAllCategories();
        Category GetCategory(int id);
        Category GetCategory(string name);
        ICollection<Pokemon> GetPokemonByCategoryId(int categoryId);
        bool IsCategoryExist(int id);
    }
}
