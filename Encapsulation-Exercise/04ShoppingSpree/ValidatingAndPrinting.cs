using System;
using System.Collections.Generic;
using System.Linq;

namespace _04ShoppingSpree
{
    public static class ValidatingAndPrinting
    {
       public static void ValidateName(string name)
        {
            if (name.Trim() == string.Empty)
            {
                throw new ArgumentException("Name cannot be empty");
            }
        }

       public static void ValidateMoney(decimal amaunt)
        {
            if (amaunt <0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
        }

        public static void PrintPersonsPurchasesFromList(List<Person> persons)
        {
            foreach (var person in persons)
            {
                if (person.Products.Count==0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                    continue;
                }
                Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(x=>x.Name))}");
            }
        }
    }
}