using System;
using System.Linq;

namespace _10_Car_Salesman
{
    class Program
    {
        static void Main()
        {
            int numberOfEngines = int.Parse(Console.ReadLine());
            Engine[] engines = new Engine[numberOfEngines];
            string[] input;
            for (int i = 0; i < numberOfEngines; i++)
            {
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Engine current;
                if (input.Length == 4)
                {
                    current = new Engine(input[0], input[1], int.Parse(input[2]), input[3]);
                }
                else if (input.Length == 2)
                {
                    current = new Engine(input[0], input[1]);
                }
                else
                {
                    int displacement;
                    if (int.TryParse(input[2], out displacement))
                    {
                        current = new Engine(input[0], input[1], displacement);
                    }
                    else
                    {
                        current = new Engine(input[0], input[1], input[2]);
                    }
                }
                engines[i] = current;
            }
            int numberOfCars = int.Parse(Console.ReadLine());
            Car[] cars = new Car[numberOfCars];
            for (int i = 0; i < numberOfCars; i++)
            {
                input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                Engine engine = engines.FirstOrDefault(x => x.Model == input[1]);
                Car current;
                if (input.Length == 4)
                {
                    current = new Car(input[0], engine, int.Parse(input[2]), input[3]);
                }
                else if (input.Length == 2)
                {
                    current = new Car(input[0], engine);
                }
                else
                {
                    int weight;
                    if (int.TryParse(input[2], out weight))
                    {
                        current = new Car(input[0], engine, weight);
                    }
                    else
                    {
                        current = new Car(input[0], engine, input[2]);
                    }
                }
                cars[i] = current;
            }
            foreach (Car vehicle in cars)
            {
                Console.WriteLine($"{vehicle.Model}:");
                Console.WriteLine($"  {vehicle.Engine.Model}:");
                Console.WriteLine($"    Power: {vehicle.Engine.Power}");
                Console.WriteLine($"    Displacement: {vehicle.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {vehicle.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {vehicle.Weight}");
                Console.WriteLine($"  Color: {vehicle.Color}");
            }
        }
    }
}