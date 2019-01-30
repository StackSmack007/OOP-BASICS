namespace BorderControl.Contracts
{
    public interface IBuyer
    {
        int Food { get; }
        string Name { get; }
        void BuyFood();
    }
}