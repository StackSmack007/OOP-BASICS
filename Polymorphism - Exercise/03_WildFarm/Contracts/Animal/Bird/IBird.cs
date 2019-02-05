namespace WildFarm.Contracts.Animal.Bird
{
    public interface IBird : IAnimal
    {
        double WingSize { get; }
    }
}