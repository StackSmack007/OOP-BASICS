using StorageMaster.Model.Products;
using StorageMaster.Model.Vehicles;
using System.Collections.Generic;

namespace StorageMaster.Contracts
{
    public   interface IStorage
    {
        string Name { get; }
        int Capacity { get; }
        int GarageSlots { get; }
        bool IsFull { get; }
        IReadOnlyCollection<Vehicle> Garage { get; }
        IReadOnlyCollection<Product> Products { get; }
    }
}