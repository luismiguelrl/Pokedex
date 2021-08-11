namespace Neksis.Pokedex.Pokemon.Infraestructure.PokemonApi.Clients
{
    using Neksis.Pokedex.Pokemon.Infraestructure.PokemonApi.Model;
    using System.Collections.Generic;

    public interface IPokemonClient
    {
        List<PokemonResult> GetPokemons();
    }
}
