using BorderControl.Contracts;
using BorderControl.Factory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl.Core
{
    public class Engine
    {
        private ResidentFactory factory;
        private ICollection<object> residents;
        public Engine()
        {
            factory = new ResidentFactory();
            residents = new List<object>();
        }

        public void Run()
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                residents.Add(factory.GetResident(input));
            }
            residents = residents.Where(x => x != null).ToList();
            string yearToLookFOr = Console.ReadLine();
            foreach (IBirthable newborn in residents.Where(x => x is IBirthable).Select(x=>(IBirthable)x).Where(x=>x.BirthDay.EndsWith(yearToLookFOr)))
            {
                Console.WriteLine(newborn.BirthDay);
            }
        }
    }
}