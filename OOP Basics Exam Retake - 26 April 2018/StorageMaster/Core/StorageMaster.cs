using StorageMaster.Model.Products;
using StorageMaster.Model.Storages;
using StorageMaster.Model.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Core
{
    public class StorageMaster
    {
        private List<Storage> storageRegistry;
        private List<Product> productPool;
        private Vehicle currentVehicle;

        public StorageMaster()
        {
            storageRegistry = new List<Storage>();
            productPool = new List<Product>();
        }

        public string AddProduct(string type, double price)
        {
            switch (type.ToLower())
            {
                case "gpu": productPool.Add(new Gpu(price)); break;
                case "harddrive": productPool.Add(new HardDrive(price)); break;
                case "ram": productPool.Add(new Ram(price)); break;
                case "solidstatedrive": productPool.Add(new SolidStateDrive(price)); break;
                default: throw new InvalidOperationException("Invalid product type!");
            }
            return $"Added {type} to pool";
        }

        public string RegisterStorage(string type, string name)
        {
            switch (type.ToLower())
            {
                case "automatedwarehouse": storageRegistry.Add(new AutomatedWarehouse(name)); break;
                case "distributioncenter": storageRegistry.Add(new DistributionCenter(name)); break;
                case "warehouse": storageRegistry.Add(new Warehouse(name)); break;
                default: throw new InvalidOperationException("Invalid storage type!");
            }
            return $"Registered {name}";
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            currentVehicle = storageRegistry.FirstOrDefault(x => x.Name == storageName).Garage.ElementAt(garageSlot);
            return $"Selected {currentVehicle.GetType().Name}";
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            int productsTransfered = 0;
            foreach (string item in productNames)
            {
                Product product = productPool.LastOrDefault(x => x.GetType().Name == item);

                if (product is null) throw new InvalidOperationException($"{item} is out of stock!");
                try
                {
                    currentVehicle.LoadProduct(product); 
                    productPool.Remove(product);
                    productsTransfered++;
                }
                catch (InvalidOperationException ioe)
                {
                    break;
                }
            }
            return $"Loaded {productsTransfered}/{productNames.Count()} products into {currentVehicle.GetType().Name}";
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            Storage source = storageRegistry.FirstOrDefault(x => x.Name == sourceName);
            Storage destination = storageRegistry.FirstOrDefault(x => x.Name == destinationName);
            if (source is null || destination is null)
            {
                throw new InvalidOperationException($"Invalid {(source is null ? "source" : "destination")} storage!");
            }
            int destinationGarageSlot = source.SendVehicleTo(sourceGarageSlot, destination);
            return $"Sent {destination.Garage.ElementAt(destinationGarageSlot).GetType().Name} to {destinationName} (slot {destinationGarageSlot})";
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            Storage storage = storageRegistry.FirstOrDefault(x => x.Name == storageName);
            if (storage is null) throw new InvalidOperationException($"No {storageName} in the register");
            int productsInVehicle = storage.Garage.ElementAt(garageSlot).Trunk.Count;
            var unloadedCount = storage.UnloadVehicle(garageSlot);
            return $"Unloaded { unloadedCount}/{ productsInVehicle} products at { storageName}";
        }

        public string GetStorageStatus(string storageName)
        {
            Storage storage = storageRegistry.FirstOrDefault(x => x.Name == storageName);

            var productsOfStorage = storage.Products
                                           .GroupBy(x => x.GetType().Name)
                                           .ToDictionary(x => x.Key, x => x.Count())
                                           .OrderByDescending(x => x.Value)
                                           .ThenBy(x => x.Key);
            List<string> items = new List<string>(productsOfStorage.Count());
            StringBuilder sb = new StringBuilder();
            foreach (var kvp in productsOfStorage)
            {
                items.Add($"{kvp.Key} ({kvp.Value})");
            }
            double totalweight = storage.Products.Sum(x => x.Weight);
            sb.Append($"Stock ({totalweight}/{storage.Capacity}): [{string.Join(", ", items)}]\nGarage: [");//??????rounding of double
            items = new List<string>(storage.Garage.Count);
            foreach (Vehicle item in storage.Garage)
            {
                if (item is null)
                {
                    items.Add("empty");
                }
                else
                {
                    items.Add(item.GetType().Name);
                }
            }
            sb.Append($"{string.Join('|', items)}]");
            return sb.ToString();
        }

        public string GetSummary()
        {
            Dictionary<string, double> storages = storageRegistry.GroupBy(x => x.Name)
                                          .ToDictionary(x => x.Key, x => x.Sum(z => z.Products.Sum(f => f.Price)));

            StringBuilder sb = new StringBuilder();

            foreach (var store in storages.OrderByDescending(x => x.Value))
            {
                sb.AppendLine($"{store.Key}:");
                sb.AppendLine($"Storage worth: ${store.Value:F2}");
            }
            return sb.ToString();
        }
    }
}