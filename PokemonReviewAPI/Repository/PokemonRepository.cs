﻿using PokemonReviewAPI.Data;
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

        public Pokemon GetPokemon(int id)
        {
            return _context.Pokemon.Where(p => p.Id == id).FirstOrDefault();
        }

        public Pokemon GetPokemon(string name)
        {
            return _context.Pokemon.Where(p => p.Name == name).FirstOrDefault();
        }

        public decimal GetPokemonRating(int pokemonId)
        {
            var review = _context.Reviews.Where(r => r.Pokemon.Id == pokemonId);

            if (!review.Any()) return 0;

            return (decimal)review.Sum(r => r.Rating) / review.Count();
        }

        public bool PokemonExists(int pokemonId)
        {
            return _context.Pokemon.Any(p => p.Id == pokemonId);
        }
    }
}
