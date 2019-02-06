using System;

namespace _03Fixing
{
    public class Program
    {
        static void Main()
        {
            string[] weekdays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday" };

            for (int i = 0; i <= 5; i++)
            {
                try
                {
                    Console.WriteLine(weekdays[i]);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadLine();
        }
    }
}