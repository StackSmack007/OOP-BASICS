using System;

namespace _03_Ferrari
{
    class StartUp
    {
        static void Main()
        {
            string driver = Console.ReadLine();
            Ferrari car = new Ferrari("488-Spider", driver);
            Console.WriteLine($"{car.Model}/{car.UseBrakes()}/{car.PushTheGasPedal()}/{car.Driver}");
        }
    }
}