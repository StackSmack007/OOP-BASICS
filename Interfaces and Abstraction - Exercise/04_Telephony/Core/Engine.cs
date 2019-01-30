using System;
using Telephony.Model;
using Telephony.Contracts;
namespace Telephony.Core
{
    public class Engine
    {
        private Smartphone smartphone;

        public Engine()
        {
            smartphone = new Smartphone();
        }
        
        internal void Run()
        {
            string[] telNumbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();
            foreach (string number in telNumbers)
            {
                try
                {
                    smartphone.CallNumber(number);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            foreach (string url in urls)
            {
                try
                {
                    smartphone.BrowseTheWeb(url);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}