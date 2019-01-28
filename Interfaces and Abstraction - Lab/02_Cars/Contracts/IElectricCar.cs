namespace Cars.Contracts
{
    interface IElectricCar:ICar
    {
        int Battery { get; }
    }
}