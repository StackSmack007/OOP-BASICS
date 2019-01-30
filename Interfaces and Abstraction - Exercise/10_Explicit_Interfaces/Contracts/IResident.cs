namespace ExplicitInterfaces.Contracts
{
    public interface IResident
    {
        string Name { get; set; }
        string Country { get; set; }
        void GetName();//mrs
    }
}