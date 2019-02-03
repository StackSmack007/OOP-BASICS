using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main()
        {
            Shape circle = new Circle(3.5);
            Shape rectangle = new Rectangle(10, 7.5);

            Console.Write(rectangle.Draw());
            Console.WriteLine($"{rectangle.CalculateArea():F2}");
            Console.WriteLine($"{rectangle.CalculatePerimeter():F2}");

            Console.WriteLine(circle.Draw());
            Console.WriteLine($"{circle.CalculateArea():F2}");
            Console.WriteLine($"{circle.CalculatePerimeter():F2}");
        }
    }
}