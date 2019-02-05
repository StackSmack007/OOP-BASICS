namespace WildFarm.Contracts.Animal
{
    public interface IAnimal
    {
        string Name { get; }
        double Weight { get; }
        int FoodEaten { get; }//??
        string Sound();
    }
}