namespace StorageMaster.Model.Products
{
    using Contracts;
    using System;
    public abstract class Product : IProduct
    {
        private double price;
        private double weight;

        public Product(double price,double weight)
        {
            Price = price;
            Weight = weight;
        }

        public double Price
        { get => price;
            private set
            {
                if (value<0)
                {
                    throw new InvalidOperationException("Price cannot be negative!");
                }
                price = value;
            }
        }
       public double Weight { get => weight;protected set => weight = value; }
    }
}