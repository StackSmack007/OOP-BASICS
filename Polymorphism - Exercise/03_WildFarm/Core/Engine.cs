using System;
using System.Collections.Generic;
using WildFarm.Factory;
using WildFarm.Model.Animal;

namespace WildFarm.Core
{
    public class Engine
    {
        private List<Animal> animals;
        private AnimalFactory factory;


        public Engine()
        {
            animals = new List<Animal>();
            factory = new AnimalFactory();
        }

        public void Run()
        {
            string[] input;

            while ((input=Console.ReadLine().Split())[0]!="End")
            {
                Animal currentAnimal = factory.Produce(input);
                animals.Add(currentAnimal);
                if (currentAnimal is Animal)
                {
                    Console.WriteLine(currentAnimal.Sound());
                }
                string[] feedInfo = Console.ReadLine().Split();
                string foodType = feedInfo[0];
                int foodAmaunt = int.Parse(feedInfo[1]);
                try
                {
                    currentAnimal.Eat(foodType,foodAmaunt);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
            animals.ForEach(x => Console.WriteLine(x));
        }
    }
}