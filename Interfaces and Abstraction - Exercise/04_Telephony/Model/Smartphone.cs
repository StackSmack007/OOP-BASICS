using System;
using System.Linq;
using Telephony.Contracts;
namespace Telephony.Model
{
    public class Smartphone :ICallOtherPhones,IBrowseInTheWorldWideWeb
    {
        public void CallNumber(string number)
        {
            if (!number.All(x => char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid number!");
            }
            Console.WriteLine($"Calling... {number}");
        }

        public void BrowseTheWeb(string adress)
        {
            if (adress.Any(x => char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid URL!");
            }
            Console.WriteLine($"Browsing: {adress}!");
        }
    }
}