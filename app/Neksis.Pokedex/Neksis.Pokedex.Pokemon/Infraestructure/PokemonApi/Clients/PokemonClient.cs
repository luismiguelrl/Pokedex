namespace Neksis.Pokedex.Pokemon.Infraestructure.PokemonApi.Clients
{
    using Neksis.Pokedex.Pokemon.Infraestructure.PokemonApi.Model;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;

    public class PokemonClient : IPokemonClient
    {
        public PokemonClient()
        {

        }

        public List<PokemonResult> GetPokemons()
        {
            List<PokemonResult> pokemons = new List<PokemonResult>();

            string url = "https://raw.githubusercontent.com/fanzeyi/pokemon.json/master/pokedex.json";
            string urlImage = "https://github.com/fanzeyi/pokemon.json/blob/master/images/{0}.png";
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(url);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage httpResponse = httpClient.GetAsync("").Result;
                if (httpResponse.IsSuccessStatusCode)
                {
                    var response = httpResponse.Content.ReadAsStringAsync();
                    pokemons = JsonConvert.DeserializeObject<List<PokemonResult>>(response.Result);
                }
            }

            foreach (var item in pokemons)
            {
                item.IdImage = $"{item.Id.ToString().PadLeft(3, '0')}.png";
                item.Image = string.Format(urlImage, item.Id.ToString().PadLeft(3, '0'));
            }

            return pokemons;
        }

    }
}
