using PokemonReviewAPI.Models;

namespace PokemonReviewAPI.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetAllPokemon();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);
        decimal GetPokemonRating(int pokemonId);
        bool IsPokemonExists(int pokemonId);
    }
}
