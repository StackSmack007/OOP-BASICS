using System;

namespace _06ValidPerson
{
    public class ErrorMaden : ArgumentException
    {
        public string Clarification { get; set; }

        public ErrorMaden(string message, string clarification) : base(message) { Clarification = clarification; }
     
        public void WhoAmI()
        {
            Console.WriteLine("Nobody knows...");
        }
    }
}