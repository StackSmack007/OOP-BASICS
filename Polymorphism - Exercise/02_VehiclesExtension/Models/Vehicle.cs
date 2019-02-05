using System;

namespace Vehicles.Models
{
    public abstract class Vehicle
    {
        protected double fuelAmmount;
        protected double litersPerKm;
        protected double tankCappacity;

        public Vehicle(double fuelAmmount, double litersPerKm, double tankCappacity)
        {
            TankCappacity = tankCappacity;
            FuelAmmount = fuelAmmount > tankCappacity ? 0 : fuelAmmount;
            LitersPerKm = litersPerKm;
        }

        public double FuelAmmount
        {
            get => this.fuelAmmount;
            protected set
            {

                this.fuelAmmount = value;
            }
        }

        public virtual double TankCappacity { get => tankCappacity; protected set => tankCappacity = value; }

        public virtual double LitersPerKm { get => litersPerKm; protected set => litersPerKm = value; }

        public virtual void Drive(double distance)
        {
            double fuelNeeded = distance * LitersPerKm;
            if (this.FuelAmmount < fuelNeeded)
            {
                throw new ArgumentException($"{GetType().Name} needs refueling");
            }
            Console.WriteLine($"{GetType().Name} travelled {distance} km");
            FuelAmmount -= fuelNeeded;
        }

        public virtual void Refuel(double amaunt)
        {
            if (amaunt <= 0)
            {
                throw new ArgumentException($"Fuel must be a positive number");
            }
            else if (tankCappacity < FuelAmmount + amaunt)
            {
                throw new ArgumentException($"Cannot fit {amaunt} fuel in the tank");
            }
            FuelAmmount += amaunt;
        }
        public void DisplayFuel()
        {
            Console.WriteLine($"{GetType().Name}: {FuelAmmount:F2}");
        }
    }
}