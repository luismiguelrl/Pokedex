
namespace Neksis.Pokedex.Pokemon.Application
{
    using Neksis.Pokedex.Pokemon.Infraestructure.PokemonApi.Model;
    using System.Collections.Generic;

    public interface IPokemonApplication
    {
        List<PokemonResult> GetPokemons();
        PokemonResult FindPokemon(int id);
    }
}
