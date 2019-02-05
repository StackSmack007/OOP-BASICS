using System;

namespace Vehicles.Core
{
    using Models;
    public class Engine
    {

        private Vehicle[] carTruckBuss;

        public Engine()
        {
            carTruckBuss = new Vehicle[3];
        }

        public void Run()
        {
            try
            {
                string[] carInput = Console.ReadLine().Split();
                carTruckBuss[0] = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]), double.Parse(carInput[3]));
                string[] truckInput = Console.ReadLine().Split();
                carTruckBuss[1] = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]), double.Parse(truckInput[3]));
                string[] bussInput = Console.ReadLine().Split();
                carTruckBuss[2] = new Bus(double.Parse(bussInput[1]), double.Parse(bussInput[2]), double.Parse(bussInput[3]));
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string vehicleType = input[1];
                string operation = input[0];
                double amaunt = double.Parse(input[2]);
                try
                {
                    if (vehicleType == "Car")
                    {
                        Operate(carTruckBuss[0], operation, amaunt);
                    }
                    else if (vehicleType == "Truck")
                    {
                        Operate(carTruckBuss[1], operation, amaunt);
                    }
                    else if (vehicleType == "Bus")
                    {
                        Operate(carTruckBuss[2], operation, amaunt);
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
            Array.ForEach(carTruckBuss, x => x.DisplayFuel());
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
            else if (operation == "DriveEmpty" && vehicle is Bus autobus)
            {
                autobus.DriveEmpty(amaunt);
            }
        }
    }
}