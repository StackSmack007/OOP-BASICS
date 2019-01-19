using System;
using System.Collections.Generic;
using System.Text;

namespace _10_Car_Salesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private string weight;
        private string color;
        public Car() { }
        public Car(string model,Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = "n/a";
            this.Color = "n/a";
        }
        public Car(string model, Engine engine,int weight):this(model,engine)
        {
            this.Weight = weight.ToString() ;
        }
        public Car(string model, Engine engine, string color) : this(model, engine)
        {
            this.Color = color;
        }
        public Car(string model, Engine engine,int weight, string color) : this(model, engine)
        {
            this.Weight = weight.ToString();
            this.Color = color;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }


        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
