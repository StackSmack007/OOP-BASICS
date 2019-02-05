namespace WildFarm.Model.Animal.Mammal.Feline
{
    using Contracts.Animal.Mammal.Feline;
    using WildFarm.Contracts.Food;

    public class Tiger : Feline
    {

        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
            weightGain = 1.00;
            foodTypesAllowed = new FoodTypes[] { FoodTypes.Meat };
        }

        public string Breed { get; private set; }

        public override string Sound()
        {
            return "ROAR!!!";
        }
    }
}