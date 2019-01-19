using System;

namespace _05_Date_Modifier
{
    class Program
    {
        static void Main()
        {
            DateModifier daysDiff = new DateModifier();
            daysDiff.GetDays(Console.ReadLine(), Console.ReadLine());


            Console.WriteLine(string.Join("",daysDiff.Days));
        }
    }
}
