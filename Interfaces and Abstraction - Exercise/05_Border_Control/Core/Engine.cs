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
        private List<IDPosses> residents;
        public Engine()
        {
            factory = new ResidentFactory();
            residents = new List<IDPosses>();
        }

        public void Run()
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                residents.Add(factory.GetResident(input));
            }
            string idToLookFOr = Console.ReadLine();
            foreach (IDPosses resident in residents.Where(x => x.Id.EndsWith(idToLookFOr)))
            {
                Console.WriteLine(resident.Id);
            }
        }
    }
}