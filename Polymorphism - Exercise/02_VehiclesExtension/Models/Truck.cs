namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double additionalFuelConsumtpion = 1.6;

        public Truck(double fuelAmmount, double litersPerKm, double tanckCappacity) : base(fuelAmmount, litersPerKm, tanckCappacity)
        {
            LitersPerKm += additionalFuelConsumtpion;
        }

        public override double LitersPerKm { get => litersPerKm; protected set => litersPerKm = value; }

        public override void Refuel(double amaunt)
        {
            base.Refuel(amaunt);
            FuelAmmount -= amaunt * 0.05;
        }
    }
}