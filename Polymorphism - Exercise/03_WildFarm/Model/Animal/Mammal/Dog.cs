namespace WildFarm.Model.Animal.Mammal
{
    using Contracts.Animal.Mammal;
    using WildFarm.Contracts.Food;

    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
           weightGain = 0.4;
            foodTypesAllowed = new FoodTypes[] { FoodTypes.Meat };
        }

        public override string Sound()
        {
            return "Woof!";
        }
    }
}