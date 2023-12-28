using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewAPI.DTO;
using PokemonReviewAPI.Interfaces;
using PokemonReviewAPI.Models;

namespace PokemonReviewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;
        private readonly IMapper _mapper;

        public PokemonController(IPokemonRepository pokemonRepository, IMapper mapper)
        {
            _pokemonRepository = pokemonRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
        public IActionResult GetAllPokemon()
        {
            var pokemons = _mapper.Map<List<PokemonDTO>>(_pokemonRepository.GetAllPokemon());

            if (!ModelState.IsValid) 
                return BadRequest(ModelState);

            return Ok(pokemons);
        }

        [HttpGet("{pokemonId}")]
        [ProducesResponseType(200, Type = typeof(Pokemon))]
        [ProducesResponseType(400)]
        public IActionResult GetPokemon(int pokemonId)
        {
            if(!_pokemonRepository.IsPokemonExists(pokemonId)) 
                return NotFound();

            var pokemon = _mapper.Map<PokemonDTO>(_pokemonRepository.GetPokemon(pokemonId));

            if (!ModelState.IsValid) 
                return BadRequest(ModelState);

            return Ok(pokemon);
        }

        [HttpGet("{pokemonId}/rating")]
        [ProducesResponseType(200, Type = typeof(decimal))]
        [ProducesResponseType(400)]
        public IActionResult GetPokemonRating(int pokemonId)
        {
            if (!_pokemonRepository.IsPokemonExists(pokemonId))
                return NotFound();

            var rating = _pokemonRepository.GetPokemonRating(pokemonId);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(rating);
        }
    }
}
