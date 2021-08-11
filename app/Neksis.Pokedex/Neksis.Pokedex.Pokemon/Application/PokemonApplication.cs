namespace Neksis.Pokedex.Pokemon.Application
{
    using Neksis.Pokedex.Pokemon.Infraestructure.PokemonApi.Clients;
    using Neksis.Pokedex.Pokemon.Infraestructure.PokemonApi.Model;
    using System.Collections.Generic;
    using System.Linq;

    public class PokemonApplication : IPokemonApplication
    {
        private readonly IPokemonClient pokemonClient;
        public PokemonApplication(IPokemonClient pokemonClient)
        {
            this.pokemonClient = pokemonClient;
        }

        public List<PokemonResult> GetPokemons()
        {
            return pokemonClient.GetPokemons();
        }

        public PokemonResult FindPokemon(int id)
        {
            PokemonResult result = new PokemonResult();

            List<PokemonResult> pokemons = pokemonClient.GetPokemons();
            result = pokemons.FirstOrDefault(p => p.Id == id);
            return result;
        }
    }
}
