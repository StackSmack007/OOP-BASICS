using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Raw_Data
{
    public class Tire
    {
        public Tire(double pressure,int age)
        {
            this.Age = age;
            this.Pressure = pressure;
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private double pressure;

        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }


    }
}
