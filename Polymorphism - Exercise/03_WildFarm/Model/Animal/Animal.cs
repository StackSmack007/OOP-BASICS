namespace WildFarm.Model.Animal
{
    using Contracts.Animal;
    using System;
    using System.Linq;
    using WildFarm.Contracts.Food;

    public abstract class Animal : IAnimal
    {
        protected double weightGain;
        protected FoodTypes[] foodTypesAllowed;

        public Animal(string name, double weight)
        {
            FoodEaten = 0;
            Name = name;
            Weight = weight;
        }

        public string Name { get; protected set; }

        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        public abstract string Sound();

        public void Eat(string food,int amaunt)
        {
            ArgumentException spitFood = new ArgumentException($"{this.GetType().Name} does not eat {food}!");
            FoodTypes foodType;
            if (!Enum.TryParse(food, out foodType))
            {
                throw spitFood;
            }
            if (!this.foodTypesAllowed.Contains(foodType))
            {
                throw spitFood;
            }
            Weight += amaunt * weightGain;
            FoodEaten += amaunt;
        }
    }
}