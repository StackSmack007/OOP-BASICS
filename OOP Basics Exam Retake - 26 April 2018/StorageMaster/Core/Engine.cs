using System;
using System.Linq;

namespace StorageMaster.Core
{
    public class Engine
    {
        private StorageMaster sm;

        public Engine()
        {
            sm = new StorageMaster();
        }

        public void Run()
        {
            string[] inputArgs;
            while ((inputArgs = Console.ReadLine().Split())[0] != "END")
            {
                string command = inputArgs[0].ToLower();
                try
                {
                    if (command == "addproduct")
                    {
                        string type = inputArgs[1];
                        double price = double.Parse(inputArgs[2]);
                        Console.WriteLine(sm.AddProduct(type, price));
                    }
                    else if (command == "registerstorage")
                    {
                        string type = inputArgs[1];
                        string name = inputArgs[2];
                        Console.WriteLine(sm.RegisterStorage(type, name));
                    }
                    else if (command == "selectvehicle")
                    {
                        string storageName = inputArgs[1];
                        int garageSlot = int.Parse(inputArgs[2]);
                        Console.WriteLine(sm.SelectVehicle(storageName, garageSlot));
                    }
                    else if (command == "loadvehicle")
                    {
                        string[] products = inputArgs.Skip(1).ToArray();
                        Console.WriteLine(sm.LoadVehicle(products));
                    }
                    else if (command == "sendvehicleto")
                    {
                        string sourceName = inputArgs[1];
                        int sourceGarageSlot = int.Parse(inputArgs[2]);
                        string destinationName = inputArgs[3];
                        Console.WriteLine(sm.SendVehicleTo(sourceName, sourceGarageSlot, destinationName));
                    }
                    else if (command == "unloadvehicle")
                    {
                        string storageName = inputArgs[1];
                        int garageSlot = int.Parse(inputArgs[2]);
                        Console.WriteLine(sm.UnloadVehicle(storageName, garageSlot));
                    }
                    else if (command == "getstoragestatus")
                    {
                        string storageName = inputArgs[1];
                        Console.WriteLine(sm.GetStorageStatus(storageName));
                    }
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine("Error: " + ioe.Message);
                }
            }
            Console.Write(sm.GetSummary());
        }
    }
}