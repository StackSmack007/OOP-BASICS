using System;

namespace _04ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get { return name; }
            set
            {
                try
                {
                    ValidatingAndPrinting.ValidateName(value);
                    this.name = value;
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    Environment.Exit(0);
                }
            }
        }

        public decimal Cost
        {
            get { return cost; }
            set
            {
                try
                {
                    ValidatingAndPrinting.ValidateMoney(value);
                    this.cost = value;
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    Environment.Exit(0);
                }
            }
        }



    }
}
