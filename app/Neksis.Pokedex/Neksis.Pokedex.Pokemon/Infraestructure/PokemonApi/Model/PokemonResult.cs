namespace Neksis.Pokedex.Pokemon.Infraestructure.PokemonApi.Model
{
    using System.Collections.Generic;

    public class PokemonResult
    {
        //"id": 1,
        //"name": {
        //  "english": "Bulbasaur",
        //  "japanese": "フシギダネ",
        //  "chinese": "妙蛙种子",
        //  "french": "Bulbizarre"
        //},
        //"type": [
        //  "Grass",
        //  "Poison"
        //],
        //"base": {
        //  "HP": 45,
        //  "Attack": 49,
        //  "Defense": 49,
        //  "Sp. Attack": 65,
        //  "Sp. Defense": 65,
        //  "Speed": 45
        //}

        public int Id { get; set; }
        public string Image { get; set; }
        public string IdImage { get; set; }
        public PokemonNameResult Name { get; set; }
        public PokemonBaseResult Base { get; set; }

        public PokemonResult()
        {
            Name = new PokemonNameResult();
            Base = new PokemonBaseResult();
        }
        public List<string> Type { get; set; } = new List<string>();
    }

    public class PokemonNameResult
    {
        public string English { get; set; }
        public string Japanese { get; set; }
        public string Chinese { get; set; }
        public string French { get; set; }
    }
    public class PokemonBaseResult
    {
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SPAttack { get; set; }
        public int SPDefense { get; set; }
        public int Speed { get; set; }
    }
}
