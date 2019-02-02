using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleSnake.GameObjects.Foods
{
    public abstract class Food : Point
    {
        private Random random;
        private Queue<Point> snake;
        private Wall wall;
        protected char foodsymbol;
        protected int foodPoints;

        public Food(Wall wall, int points, char symbol) : base(wall.HorX, wall.VerY)//the coordinates here are irrelevant just to pass the constructor
        {
            this.wall = wall;
            this.FoodPoints = points;
            this.foodsymbol = symbol;
            random = new Random();
        }

        public int FoodPoints { get => foodPoints;protected set => foodPoints = value; }

        public void SetRandomPosition(Queue<Point> snake)
        {
            int horX;
            int verY;
            do
            {
                horX = random.Next(2, wall.HorX - 1);
                verY = random.Next(2, wall.VerY - 1);
            }
            while (snake.Any(x => x.HorX == horX && x.VerY == verY));
            this.HorX = horX;
            this.VerY = verY;

          //  Console.BackgroundColor = ConsoleColor.Yellow;
            Draw(foodsymbol);
            
        }

        public bool IsFoodPoint(Point snakeHead)
        {
            return snakeHead.HorX == this.HorX && snakeHead.VerY == this.VerY;
        }
    }
}