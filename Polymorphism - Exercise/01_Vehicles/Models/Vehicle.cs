using System;

namespace Vehicles.Models
{
    public abstract class Vehicle 
    {



        protected double fuelAmmount;
        protected double litersPerKm;

        public Vehicle(double fuelAmmount, double litersPerKm)
        {
            FuelAmmount = fuelAmmount;
            LitersPerKm = litersPerKm;
         }

        public virtual double FuelAmmount
        {
            get => this.fuelAmmount;
            protected set
            {
                this.fuelAmmount = value;
            }
        }

        public virtual double LitersPerKm { get => litersPerKm; protected set => litersPerKm = value; }


        public virtual void Drive(double distance)
        {
            double fuelNeeded = distance * LitersPerKm;
            if (this.FuelAmmount < fuelNeeded)
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} travelled {distance} km");
                fuelAmmount -= fuelNeeded;
            }
        }

        public virtual void Refuel(double amaunt)
        {
            FuelAmmount += amaunt;
        }

        public void DisplayFuel()
        {
            Console.WriteLine($"{GetType().Name}: {FuelAmmount:F2}");
        }
    }
}