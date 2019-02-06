using System;

namespace _05ConvertToDouble
{
  public  class Program
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    Console.WriteLine(Convert(input)-10);
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine("Next try");
                    continue;
                }
            }
        }

        static double Convert(string input)
        {
            try
            {
                return System.Convert.ToDouble(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input the string is not correct!");
                throw;
            }
            catch (OverflowException)
            {
                Console.WriteLine("number too large double limit reached");
                throw;
            }
        }
    }
}