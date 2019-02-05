namespace WildFarm.Model.Animal.Mammal.Bird
{
    using Contracts.Animal.Bird;
    using WildFarm.Contracts.Food;

    public class Owl : Bird
    {

        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
            weightGain = 0.25;
            foodTypesAllowed = new FoodTypes[] { FoodTypes.Meat };
        }

        public override string Sound()
        {
            return "Hoot Hoot";
        }
    }
}