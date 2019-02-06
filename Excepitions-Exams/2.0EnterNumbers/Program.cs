using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._0EnterNumbers
{
    public class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("All of the numbers are: {0}", string.Join(" ", EnterNumbers(start, end).Reverse()));
        }


        private static Stack<int> EnterNumbers(int start, int end)
        {
            Stack<int> numbers = new Stack<int>(10);

            while (numbers.Count < 10)
            {
                int num = int.Parse(Console.ReadLine());
                try
                {
                    if (start > num || end < num)
                    {
                        throw new ArgumentException("Invalid number! range does not allow entry!");
                    }
                    else
                    {
                        if (numbers.Count == 0)
                        {
                            numbers.Push(num);
                            Console.WriteLine($"Entered number {num}");
                        }
                        else if (num > numbers.Peek())
                        {
                            numbers.Push(num);
                            Console.WriteLine($"Entered number {num}");
                        }
                        else
                        {
                            throw new ArgumentException("Number must be greater than the previously entered!");
                        }
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
            return numbers;
        }



    }
}