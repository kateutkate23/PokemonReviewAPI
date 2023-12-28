using PokemonReviewAPI.Models;

namespace PokemonReviewAPI.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetAllPokemon();
    }
}
