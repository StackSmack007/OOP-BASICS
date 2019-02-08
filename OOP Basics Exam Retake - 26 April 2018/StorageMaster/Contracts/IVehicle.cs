using StorageMaster.Model.Products;
using System.Collections.Generic;

namespace StorageMaster.Contracts
{
    public  interface IVehicle
    {
        int Capacity { get; }
        IReadOnlyCollection<Product> Trunk { get; }
        bool IsFull { get; }
        bool IsEmpty { get; }
        Product Unload();
    }
}