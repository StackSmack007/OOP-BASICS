using System;
using System.Collections.Generic;
using System.Text;

namespace Mordor
{
  public static  class MoodFactory
    {
        public static string GetMood(int input)
        {
            if (input < -5) return "Angry";
            else if (input <= 0) return "Sad";
            else if (input <= 15) return "Happy";
            else return "JavaScript";
        }
    }
}
