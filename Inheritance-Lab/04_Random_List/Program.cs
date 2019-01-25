using System;

namespace CustomRandomList
{
   public class StartUp
    {
        static void Main()
        {
            RandomList list = new RandomList();
            list.Add("Avraam");
            list.Add("Isaak");
            list.Add("Izekiel");
            list.Add("Moisei");
            list.Add("Solomon");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(list.RandomString());
            }
        }
    }
}