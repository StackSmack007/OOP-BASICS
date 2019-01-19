using System;
using System.Linq;

namespace _08_Raw_Data
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Car[] vehicles = new Car[n];
            for (int i = 0; i <n; i++)
            {
                vehicles[i] = new Car(Console.ReadLine().Split());
            }
            string cargoType = Console.ReadLine();
            var result = vehicles.Where(x => x.CargoType == cargoType).
                Where(x=> cargoType == "flamable"?x.EnginePower>250:x.Tires.Any(y=>y.Pressure<1.0)).ToList();
            foreach (Car mobile in result)
            {
                Console.WriteLine(mobile.Model);
            }
        }
    }
}
