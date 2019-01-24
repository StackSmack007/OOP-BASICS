using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_RawData
{
    class Car
    {
        public Car(string input)
        {
            string[] parameters = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            this.Model = parameters[0];
            int engineSpeed = int.Parse(parameters[1]);
            int enginePower = int.Parse(parameters[2]);
            this.Engine = new Engine(engineSpeed, enginePower);
            int cargoWeight = int.Parse(parameters[3]);
            string cargoType = parameters[4];
            this.Cargo = new Cargo(cargoWeight, cargoType);
            Queue<string> tires = new Queue<string>(parameters.Skip(5));
            while (tires.Count >= 2)
            {
                double tirePressure = double.Parse(tires.Dequeue());
                int tireAge = int.Parse(tires.Dequeue());
                Tires.Add(new Tire(tirePressure, tireAge));
            }
        }
        public string Model { get; }
        public Engine Engine { get; }
        public Cargo Cargo { get; }
        public List<Tire> Tires { get; } = new List<Tire>(4);
    }
}
