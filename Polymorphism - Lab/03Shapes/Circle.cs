using System;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }


        public override double CalculateArea()
        {
            return 2 * Math.PI * radius;
        }

        public override double CalculatePerimeter()
        {
            return Math.PI * radius * radius;
        }

        public override string Draw()
        {
            return "Golqmo nishto";
        }
    }
}