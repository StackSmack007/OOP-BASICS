using System;
using System.Collections.Generic;
using System.Text;

namespace _09_Rectangle_Intersection
{
    public class Rectangle
    {
        public Rectangle() { }
        public Rectangle(string input)
        {
            string[] tokens = input.Split();
            this.Id = tokens[0];
            double length = double.Parse(tokens[1]);
            double width = double.Parse(tokens[2]);
            this.topLeftX = double.Parse(tokens[3]);
            this.topLeftY = double.Parse(tokens[4]);
            this.bottomRightX = topLeftX + length;
            this.bottomRightY = topLeftY - width;
        }
        string id;
        double topLeftX;
        double topLeftY;
        double bottomRightX;
        double bottomRightY;
        public string Id { get { return this.id; } set { this.id = value; } }
        public double TopLeftX { get { return this.topLeftX; } }
        public double TopLeftY { get { return this.topLeftY; } }
        public double BottomRightX { get { return this.bottomRightX; } }
        public double BottomRightY { get { return this.bottomRightY; } }

        public void Check(Rectangle rec2)
        {
            if ((this.BottomRightX < rec2.TopLeftX || this.TopLeftX > rec2.BottomRightX) ||
                (this.topLeftY < rec2.bottomRightY || this.bottomRightY > rec2.topLeftY))
            {
                Console.WriteLine("false"); ;
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
