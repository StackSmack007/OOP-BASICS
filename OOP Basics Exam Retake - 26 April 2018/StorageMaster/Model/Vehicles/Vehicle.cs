using StorageMaster.Contracts;
using StorageMaster.Model.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorageMaster.Model.Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        private Stack<Product> trunk;

        public int Capacity { get; protected set; }
        public IReadOnlyCollection<Product> Trunk { get { return trunk; } }

        public bool IsFull
        {
            get
            {
                double cuurentLoad = trunk.Sum(x => x.Weight);
                if (cuurentLoad >= Capacity)
                {
                    return true;
                }
                return false;
            }
        }

        public bool IsEmpty
        {
            get
            {
                if (trunk.Count == 0)
                {
                    return true;
                }
                return false;
            }
        }

        public Vehicle(int cappacity)
        {
            Capacity = cappacity;
            trunk = new Stack<Product>();
        }

        public virtual void LoadProduct(Product product)
        {
            if (IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
            trunk.Push(product);
        }

        public virtual Product Unload()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }
            return trunk.Pop();
        }


    }
}
