using System;
using System.Collections.Generic;
using System.Text;

namespace Mordor
{
  public  class Food
    {
        private string name;
        private int moodValue;

        public Food(string name, int moodValue)
        {
            Name = name;
            MoodValue = moodValue;
        }

        public string Name { get => name;private set => name = value; }
        public int MoodValue { get => moodValue;private set => moodValue = value; }
    }
}
