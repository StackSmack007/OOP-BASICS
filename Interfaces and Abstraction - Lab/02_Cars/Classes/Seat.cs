using Cars.Contracts;
using System.Text;

namespace Cars.Classes
{
    public class Seat : ICar
    {
        public string Model { get; private set; }

        public string Color { get; private set; }

        public Seat(string model,string color)
        {
            Model = model;
            Color = color;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} {GetType().Name} {Model}");
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