using System;
using System.Collections.Generic;
using ExplicitInterfaces.Contracts;
using ExplicitInterfaces.Model;

namespace ExplicitInterfaces
{
   public class Program
    {
        static void Main()
        {
            List<Citizen> citizens = new List<Citizen>();
            string[] input;
            while ((input=Console.ReadLine().Split())[0]!="End")
            {
                string name = input[0];
                string country = input[1];
                int age = int.Parse(input[2]);

                citizens.Add(new Citizen(name, country, age));
            }
            foreach (Citizen person in citizens)
            {
                person.GetName();
                ((IResident)person).GetName();
            }
        }
    }
}