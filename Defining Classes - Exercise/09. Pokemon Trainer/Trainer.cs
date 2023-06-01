using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Collection { get; set; }

        public Trainer(string name)
        {
            Name = name;
            Badges = 0;
            Collection = new List<Pokemon>();
        }

        public bool HasPokemon(string element) 
        {
            return Collection.Any(pokemon => pokemon.Element == element);
        }
        public int IncreaseBadges()
        {
            return Badges++;
        }
        public void DecreaseHealth() 
        {
            foreach (var pokemon in Collection)
            {
                pokemon.Health -= 10;
            }
        }
        public void RemoveDeathPokemons()
        {
            Collection.RemoveAll(pokemon => pokemon.Health <= 0);
        }
                
    }   
}
