namespace WildFarm.Model.Animal.Mammal
{
    using Contracts.Animal.Mammal;
    using WildFarm.Contracts.Food;

    public class Mouse : Mammal
    {
 
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
           weightGain = 0.1;
            foodTypesAllowed = new FoodTypes[]{ FoodTypes.Vegetable, FoodTypes.Fruit};
        }

        public override string Sound()
        {
            return "Squeak";
        }
    }
}