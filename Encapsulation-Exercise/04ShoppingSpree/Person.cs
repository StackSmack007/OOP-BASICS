using System;
using System.Collections.Generic;

namespace _04ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<Product>();
        }
        public string Name
        {
            get { return this.name; }
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

        public decimal Money
        {
            set
            {
                try
                {
                    ValidatingAndPrinting.ValidateMoney(value);
                    this.money = value;
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    Environment.Exit(0);
                }
            }
        }

        public List<Product> Products
        {
            get { return this.products; }
            set { this.products = value; }
        }
        public void Purchase(Product product)
        {
            if (product.Cost > this.money)
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
                return;
            }
            Console.WriteLine($"{this.Name} bought {product.Name}");
            this.money -= product.Cost;
            this.Products.Add(product);
        }
    }
}