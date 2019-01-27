using System;
using System.Collections.Generic;

namespace AnimalPlanet
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Queue<InterFace> animals = new Queue<InterFace>();
            string type;
            while ((type = Console.ReadLine().Trim()) != "Beast!")
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                string gender = input.Length == 3 ? input[2] : "none";
                try
                {
                    switch (type.ToLower())
                    {
                        case "frog":
                            animals.Enqueue(new Frog(name, age, gender));
                            break;
                        case "dog":
                            animals.Enqueue(new Dog(name, age, gender));
                            break;
                        case "cat":
                            animals.Enqueue(new Cat(name, age, gender));
                            break;
                        case "kitten":
                            animals.Enqueue(new Kitten(name, age));
                            break;
                        case "tomcat":
                            animals.Enqueue(new Tomcat(name, age));
                            break;
                        default:
                            throw new ArgumentException("Invalid input!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (animals.Count != 0)
            {
                InterFace animal = animals.Dequeue();
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine(animal.GetNameAgeGender());
                Console.WriteLine(animal.ProduceSound());
            }
        }
    }
}