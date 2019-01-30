using Military.Factories;
using Military.Model;
using System;
using System.Collections.Generic;

namespace Military.Core
{
    public class Engine
    {
        private SoldierFactory factory;
        private readonly List<Soldier> soldiers;
        public Engine()
        {
            factory = new SoldierFactory();
            soldiers = new List<Soldier>();
        }
        
        public void Run()
        {
            string[] input;
            while ((input=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries))[0]!="End")
            {
                Soldier current = factory.GetSoldier(input, soldiers);
                if (current == null) continue;
                soldiers.Add(current);
            }
            foreach (Soldier soldier in soldiers)
            {
                Console.Write(soldier);
            }
        }
    }
}