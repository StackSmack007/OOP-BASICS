using System;
using Shapes.Contracts;
using Shapes.Models;

namespace Shapes
{
   public class Engine
    {
        public void Run()
        {
            int radius = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);
            IDrawable rectangle = new Rectangle(width, height);
            circle.Draw();
            rectangle.Draw();
        }
    }
}