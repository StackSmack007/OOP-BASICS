using StorageMaster.Contracts;
using StorageMaster.Model.Products;
using StorageMaster.Model.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorageMaster.Model.Storages
{
    public abstract class Storage : IStorage
    {

        private Vehicle[] garage;
        private List<Product> products;

        public string Name { get; }
        public int Capacity { get; }
        public int GarageSlots { get; }
        public IReadOnlyCollection<Vehicle> Garage
        {
            get { return Array.AsReadOnly(garage); }
        }
        public IReadOnlyCollection<Product> Products
        {
            get { return products.AsReadOnly(); }
        }

        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            Name = name;
            Capacity = capacity;
            GarageSlots = garageSlots;
            garage = new Vehicle[GarageSlots];
            FillGarage(vehicles);
            products = new List<Product>();
        }

        private void FillGarage(IEnumerable<Vehicle> vehicles)
        {
            int index = 0;
            foreach (var vehicle in vehicles)
            {
                this.garage[index++] = vehicle;
            }
        }

        public bool IsFull { get {return Products.Sum(p => p.Weight) >= Capacity; } }


        public Vehicle GetVehicle(int slot)
        {
            if (slot >= Garage.Count || slot < 0)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }
            if (Garage.ElementAt(slot) is null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }
            return Garage.ElementAt(slot);
        }

        public int SendVehicleTo(int fromSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = GetVehicle(fromSlot);
            if (deliveryLocation.Garage.All(x => x != null))
            {
                throw new InvalidOperationException("No room in garage!");
            }
            int freeSpotIndex = deliveryLocation.garage.ToList().FindIndex(x => x == null);

            deliveryLocation.garage[freeSpotIndex] = vehicle;

            this.garage[fromSlot] = null;
            return freeSpotIndex;
        }

        /// <summary>
        /// Returns Succesfully unloaded products count!
        /// </summary>
        /// <param name="fromSlot"></param>
        /// <returns></returns>
        public int UnloadVehicle(int fromSlot)
        {
            Vehicle vehicle = GetVehicle(fromSlot);
                if (IsFull)
                {
                    throw new InvalidOperationException("Storage is full!");
                }

            int unloadedProducts = 0;
            while (!vehicle.IsEmpty&&!IsFull)
            {
                products.Add(vehicle.Unload());
                unloadedProducts++;
            }
            return unloadedProducts;
        }
    }
}