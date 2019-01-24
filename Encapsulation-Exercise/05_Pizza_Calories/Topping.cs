using System;
using System.Linq;

namespace _05_Pizza_Calories
{
   public class Topping
    {
        private string type;
        private int weight;

        private string[] allowedTypes = { "meat", "veggies", "cheese", "sauce" };
        public Topping(string type, int weiht)
        {
            this.Type = type;
            this.Weight = weiht;
        }

        private string Type
        {
            set
            {
                if (allowedTypes.Contains(value.ToLower()))
                {
                    this.type = value;
                }
                else
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

            }
        }

        private int Weight
        {
            set
            {
                if (value < 0 || value > 50)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }

        public float GetCalories()
        {
            float coef = 1.0f;
            if (this.type.ToLower() == "meat") coef *= 1.2f;
            if (this.type.ToLower() == "veggies") coef *= 0.8f;
            if (this.type.ToLower() == "cheese") coef *= 1.1f;
            if (this.type.ToLower() == "sauce") coef *= 0.9f;
            return 2 * weight * coef;
        }
    }
}