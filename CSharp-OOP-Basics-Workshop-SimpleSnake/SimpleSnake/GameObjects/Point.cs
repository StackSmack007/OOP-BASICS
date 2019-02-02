using System;

namespace SimpleSnake.GameObjects
{
    public class Point
    {

        public Point(int horX, int verY)
        {
            HorX = horX;
            VerY = verY;
        }

        public int HorX { get; set; }
        public int VerY { get; set; }

        public void Draw(char symbol)
        {
            Console.SetCursorPosition(HorX, VerY);
            Console.Write(symbol);
        }

        public void Draw(int horX,int verY,char symbol)
        {
            Console.SetCursorPosition(horX, verY);
            Console.Write(symbol);
        }

    }
}