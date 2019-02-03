using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double length;
        private double height;

        public Rectangle(double length, double height)
        {
            this.length = length;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return length * height;
        }

        public override double CalculatePerimeter()
        {
            return 2d * (length + height);
        }

        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('*', (int)length));
            for (int i = 0; i < height - 2; i++)
            {
                sb.AppendLine($"*{new string(' ', (int)length - 2)}*");
            }
            sb.AppendLine(new string('*', (int)length));
            return sb.ToString();
        }
    }
}