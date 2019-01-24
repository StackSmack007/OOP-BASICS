using System;

namespace AnimalFarm.Models
{
    internal class Chicken
    {
        private const int MinAge = 0;
        private const int MaxAge = 15;

        private string name;
        private int age;

        internal Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        internal string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Trim() == "")
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                this.name = value.Trim();
            }
        }

        internal int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < MinAge || value > MaxAge)
                {
                    throw new ArgumentException("Age should be between 0 and 15.");
                }
                this.age = value;
            }
        }

        internal double ProductPerDay
        {
            get
            {
                return this.CalculateProductPerDay();
            }
        }

        private double CalculateProductPerDay()
        {
            if (this.Age >= 0 && this.Age < 4)
            {
                return 1.5;
            }
            else if (this.Age < 8)
            {
                return 2;
            }
            else if (this.Age < 12)
            {
                return 1;
            }
            return 0.75;
        }
    }
}