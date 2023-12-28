using PokemonReviewAPI.Data;
using PokemonReviewAPI.Interfaces;
using PokemonReviewAPI.Models;

namespace PokemonReviewAPI.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context) 
        { 
            _context = context;
        }
        public ICollection<Pokemon> GetAllPokemon()
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }
    }
}
