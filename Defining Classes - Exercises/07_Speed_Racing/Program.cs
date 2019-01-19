using System;
using System.Collections.Generic;

namespace _07_Speed_Racing
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Car car = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));
                cars.Add(car);
            }
            string[] command;
            while ((command = Console.ReadLine().Split())[0] != "End")
            {
                string model = command[1];
                double distance = double.Parse(command[2]);
                int index = cars.FindIndex(x => x.Model == model);
                if (index!=-1)
                {
                    cars[index].PassDistance(distance);
                }
            }
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmaunt:F2} {car.DistTraveled:F0}");
            }
        }
    }
}
