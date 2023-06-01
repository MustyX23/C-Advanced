using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            List<string> trainerOrder = new List<string>();

            string command;

            while ((command = Console.ReadLine())!= "Tournament")
            {
                //{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
                string[] pokeInfo = command.Split(' ');

                string trainerName = pokeInfo[0];
                string pokemonName = pokeInfo[1];
                string pokemonElement = pokeInfo[2];
                int pokemonHealth = int.Parse(pokeInfo[3]);


                Trainer trainer;
                if (!trainers.ContainsKey(trainerName))
                {
                    trainer = new Trainer(trainerName);
                    trainers[trainerName] = trainer;
                    trainerOrder.Add(trainerName);
                }
                else
                {
                    trainer = trainers[trainerName];
                }

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                trainer.Collection.Add(pokemon);
            }

            while ((command = Console.ReadLine()) != "End")
            {
                string element = command;

                foreach (var trainer in trainers.Values)
                {
                    if (trainer.HasPokemon(element))
                    {
                        trainer.IncreaseBadges();
                    }
                    else
                    {
                        trainer.DecreaseHealth();
                    }
                }
            }


            var sortedTrainers = trainerOrder
                .Select(trainerName => trainers[trainerName])
                .OrderByDescending(t => t.Badges)
                .ToList();

            foreach (var trainer in sortedTrainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Collection.Count}");
            }

        }
    }
}
