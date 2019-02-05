using System;

namespace Vehicles
{
    using Models;
    public class StartUp
    {
        static void Main()
        {
            string[] carInput = Console.ReadLine().Split();
            Vehicle car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]));
            string[] truckInput = Console.ReadLine().Split();
            Vehicle truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]));

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string vehicleType = input[1];
                string operation = input[0];
                double amaunt = double.Parse(input[2]);
                if (vehicleType == "Car")
                {
                    Operate(car, operation, amaunt);
                }
                else if (vehicleType == "Truck")
                {
                    Operate(truck, operation, amaunt);
                }
            }
            car.DisplayFuel();
            truck.DisplayFuel();

        }
        static void Operate(Vehicle vehicle, string operation, double amaunt)
        {
            if (operation == "Drive")
            {
                vehicle.Drive(amaunt);
            }
           else if (operation == "Refuel")
            {
                vehicle.Refuel(amaunt);
            }
        }
    }
}