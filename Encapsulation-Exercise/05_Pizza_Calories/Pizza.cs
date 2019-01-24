using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Pizza_Calories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        public Pizza()
        {

        }
        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                else
                {
                    name = value;
                }
            }
        }

        public Dough Dough
        {
            set { this.dough = value; }
        }

        public List<Topping> Toppings
        {
            get
            {
                return this.toppings;
            }
        }

        public float GetCalories()
        {
            float result = 0f;
            result += this.dough.GetCalories();
            result += this.toppings.Sum(x => x.GetCalories());
            return result;
        }
    }
}