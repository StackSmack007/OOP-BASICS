using AnimalFarm.Animals;
using AnimalFarm.Factories;
using System;
using System.Collections.Generic;

namespace AnimalFarm.Core
{
    internal class Engine
    {
        private AnimalFactory factory;
        private List<Animal> animals;
        public Engine()
        {
            factory = new AnimalFactory();
            animals = new List<Animal>();
        }
        public void Run()
        {
            string type = Console.ReadLine();
            while (type!="Beast!")
            {
                string animalInfo = Console.ReadLine();
                try
                {
                    animals.Add(factory.Produce(type, animalInfo));
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                type = Console.ReadLine();
            }
            animals.ForEach(x => x.PrintData());
        }
    }
}