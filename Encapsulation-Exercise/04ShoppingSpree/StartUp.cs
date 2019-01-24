using System;
using System.Collections.Generic;
using System.Linq;

namespace _04ShoppingSpree
{
   public class StartUp
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            List<Person> persons = new List<Person>(input.Length);
            foreach (string entry in input)
            {
                string name = entry.Split('=')[0];
                decimal money = decimal.Parse(entry.Split('=')[1]);
                persons.Add(new Person(name, money));
            }
            input = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries);
            List<Product> products = new List<Product>(input.Length);
            foreach (string entry in input)
            {
                string name = entry.Split('=')[0];
                decimal cost = decimal.Parse(entry.Split('=')[1]);
                products.Add(new Product(name, cost));
            }
            while ((input=Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries))[0]!="END")
            {
                Person person = persons.FirstOrDefault(x => x.Name == input[0]);
                Product product = products.FirstOrDefault(x => x.Name == input[1]);
                if (person is null||product is null)
                {
                    continue;
                }
                person.Purchase(product);
            }
            ValidatingAndPrinting.PrintPersonsPurchasesFromList(persons);
        }
    }
}