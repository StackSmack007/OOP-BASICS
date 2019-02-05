namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double additionalFuelConsumtpion = 1.4;
        private double economicModeFuelConsumtion;
        public Bus(double fuelAmmount, double litersPerKm, double tankCappacity) : base(fuelAmmount, litersPerKm, tankCappacity)
        {
            economicModeFuelConsumtion = litersPerKm;
            LitersPerKm += additionalFuelConsumtpion;
        }

        public  void DriveEmpty(double distance)
        {
            distance = distance * economicModeFuelConsumtion / additionalFuelConsumtpion;
            base.Drive(distance);
        }
    }
}