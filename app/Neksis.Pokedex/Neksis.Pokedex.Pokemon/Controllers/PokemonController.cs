using Microsoft.AspNetCore.Mvc;
using Neksis.Pokedex.Pokemon.Application;
using Neksis.Pokedex.Pokemon.Infraestructure.PokemonApi.Model;
using System.Collections.Generic;

namespace Neksis.Pokedex.Pokemon.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonApplication pokemonApplication;

        public PokemonController(IPokemonApplication pokemonApplication)
        {
            this.pokemonApplication = pokemonApplication;
        }

        [HttpGet]
        public List<PokemonResult> Get()
        {
            return pokemonApplication.GetPokemons();
        }

        [HttpGet("{id}")]
        public PokemonResult FindPokemon(int id)
        {
            return pokemonApplication.FindPokemon(id);
        }

    }
}
