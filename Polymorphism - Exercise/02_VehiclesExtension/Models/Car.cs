namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double additionalFuelConsumtpion = 0.9;
        public Car(double fuelAmmount, double litersPerKm,double tankCapp) : base(fuelAmmount, litersPerKm,tankCapp)
        {
           LitersPerKm += additionalFuelConsumtpion;
        }
        public override double LitersPerKm { get => litersPerKm; protected set => litersPerKm = value; }
    }
}