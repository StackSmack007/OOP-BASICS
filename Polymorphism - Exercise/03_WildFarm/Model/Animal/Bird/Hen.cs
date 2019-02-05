namespace WildFarm.Model.Animal.Mammal.Bird
{
    using Contracts.Animal.Bird;
    using WildFarm.Contracts.Food;

    public class Hen : Bird
    {
 
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
           weightGain = 0.35;
            foodTypesAllowed = new FoodTypes[]{ FoodTypes.Meat, FoodTypes.Vegetable, FoodTypes.Seeds, FoodTypes.Fruit };
    }

        public override string Sound()
        {
            return "Cluck";
        }
    }
}