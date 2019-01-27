using System;
using System.Collections.Generic;
using System.Text;

namespace Mordor
{
    public class FoodFactory
    {
        public static Food GetFood(string input)
        {
            if (input.ToLower().Contains("cram")) return new Food(input, 2);
            else if (input.ToLower().Contains("lembas")) return new Food(input, 3);
            else if (input.ToLower().Contains("apple")) return new Food(input, 1);
            else if (input.ToLower().Contains("melon")) return new Food(input, 1);
            else if (input.ToLower().Contains("honeycake")) return new Food(input, 5);
            else if (input.ToLower().Contains("mushrooms")) return new Food(input, -10);
            else return new Food("Other", -1);
        }
    }
}