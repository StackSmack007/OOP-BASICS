using System;
using System.Collections.Generic;
using System.Linq;
namespace Mordor
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim()).ToList();
            List<Food> menu = new List<Food>(input.Count);
            input.ForEach(x => menu.Add(FoodFactory.GetFood(x)));
            int points = menu.Sum(x => x.MoodValue);
            Console.WriteLine(points);
            Console.WriteLine(MoodFactory.GetMood(points));
        }
    }
}