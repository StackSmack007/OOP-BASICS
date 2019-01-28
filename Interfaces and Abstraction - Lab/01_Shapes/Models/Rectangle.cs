using Shapes.Contracts;
using System;
namespace Shapes.Models
{
    public class Rectangle : IDrawable
    {

        private int width;
        private int height; 
        private const char symbol = '*';
        public Rectangle(int width,int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Draw()
        {
            Console.WriteLine(new string(symbol,width));
            for (int i = 0; i < height-2; i++)
            {
                Console.WriteLine(symbol+$"{new string(' ',width-2)}"+symbol);
            }
            Console.WriteLine(new string(symbol, width));
        }
    }
}