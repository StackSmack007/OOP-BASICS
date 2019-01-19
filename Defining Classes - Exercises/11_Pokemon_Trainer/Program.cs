using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_Pokemon_Trainer
{
    class Program
    {
        static void Main()
        {
            string[] input;
            List<Trainer> trainers = new List<Trainer>();
            while ((input = Console.ReadLine().Split())[0] != "Tournament")
            {
                string pokeMaster = input[0];
                if (!trainers.Any(x => x.Name == pokeMaster))
                {
                    trainers.Add(new Trainer(pokeMaster));
                }
                int indexOfTrainer = trainers.FindIndex(x => x.Name == pokeMaster);
                string pokemonName = input[1];
                string element = input[2];
                int health = int.Parse(input[3]);
                trainers[indexOfTrainer].Pokemons.Add(new Pokemon(pokemonName, element, health));
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                foreach (Trainer trainer in trainers)
                {
                    if (trainer.Pokemons.Any(x => x.Element == command))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        foreach (Pokemon pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                        trainer.Pokemons = trainer.Pokemons.Where(x => x.Health > 0).ToList();
                    }
                }
            }
            foreach (var trainer in trainers.OrderByDescending(x=>x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}