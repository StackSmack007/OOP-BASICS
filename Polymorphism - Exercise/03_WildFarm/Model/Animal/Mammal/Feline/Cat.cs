namespace WildFarm.Model.Animal.Mammal.Feline
{
    using Contracts.Animal.Mammal.Feline;
    using WildFarm.Contracts.Food;

    public class Cat : Feline
    {

        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion,breed)
        {
            weightGain = 0.3;
            foodTypesAllowed = new FoodTypes[] { FoodTypes.Meat, FoodTypes.Vegetable };
        }

       

        public override string Sound()
        {
            return "Meow";
        }
    }
}