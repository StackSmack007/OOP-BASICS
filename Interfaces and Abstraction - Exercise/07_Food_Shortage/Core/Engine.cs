using BorderControl.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl.Core
{
    public class Engine
    {
        private Factory.Factory factory;
        private ICollection<IBuyer> participants;
        public Engine()
        {
            factory = new Factory.Factory();
            participants = new List<IBuyer>();
        }

        public void Run()
        {
            int numberOfParticipants = int.Parse(Console.ReadLine());
            string input;
            for (int i = 0; i < numberOfParticipants; i++)
            {
                input = Console.ReadLine();
                participants.Add(factory.GetResident(input));
            }
            while ((input = Console.ReadLine()) != "End")
            {
                IBuyer buyer = participants.FirstOrDefault(x => x.Name == input);
                if (buyer is null)   continue;
                buyer.BuyFood();
            }
            Console.WriteLine(participants.Sum(x=>x.Food));
        }
    }
}