using PokemonReviewAPI.Models;

namespace PokemonReviewAPI.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetAllCategories();
        Category GetCategory(int id);
        Category GetCategory(string name);
        ICollection<Pokemon> GetPokemonByCategoryId(int categoryId);
        bool CategoryExists(int id);
        bool CreateCategory(Category category);
        bool UpdateCategory(Category category);
        bool DeleteCategory(Category category);
        bool Save();
    }
}
