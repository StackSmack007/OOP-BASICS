using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_Raw_Data
{
    public class Car
    {
        public Car(string[] input)
        {
            this.model = input[0];
            this.engineSpeed = int.Parse(input[1]);
            this.enginePower = int.Parse(input[2]);
            this.cargoWeight = int.Parse(input[3]);
            this.cargoType = input[4];
            this.tires = new List<Tire>(4);
            input = input.Skip(5).ToArray();
            for (int i = 0; i < 8; i += 2)
            {
                double pressure = double.Parse(input[i]);
                int age = int.Parse(input[i + 1]);
                Tire currentTire = new Tire(pressure, age);
                this.tires.Add(currentTire);
            }
        }

        private string model;
        private int engineSpeed;
        private int enginePower;
        private int cargoWeight;
        private string cargoType;
        private List<Tire> tires;
        public int EnginePower
        {
            get { return enginePower; }
        }
        public string Model
        {
            get { return model; }
        }
        public string CargoType
        {
            get { return cargoType; }
        }
        public List<Tire> Tires
        {
            get { return tires; }
        }
    }
}