using Cars.Contracts;
using System.Text;

namespace Cars.Classes
{
   public class Tesla:IElectricCar
    {
        public string Model { get; private set; }

        public string Color { get; private set; }

        public int Battery { get; private set; }

        public Tesla(string model, string color,int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} {GetType().Name} {Model} with {Battery} Batteries");
            sb.AppendLine(Start());
            sb.Append(Stop());
            return sb.ToString();
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
    }
}