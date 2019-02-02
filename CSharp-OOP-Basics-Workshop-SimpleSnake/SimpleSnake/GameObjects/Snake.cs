using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleSnake.GameObjects
{
    using Foods;
    public class Snake : Point
    {
        Queue<Point> snakeBody;
        Food[] foodTypes;
        Wall wall;
        Random random;
        private int foodIndex;
        private const char snakeSymbol = '\u25CF';
        public int PointsCollected { get; private set; } = 0;

        public Snake(Wall wall) : base(0, 0)
        {
            random = new Random();
            this.wall = wall;
            snakeBody = new Queue<Point>();
            foodIndex = GetRandomIndex();
            foodTypes = new Food[3];
            GetFoods();
            CreateSnakeBody();
        }


        private void CreateSnakeBody(int row = 10, int col = 17)
        {
            for (int i = 0; i < 6; i++)
            {
                snakeBody.Enqueue(new Point(row, col + i));
            }
        }

        private void GetFoods()
        {
            foodTypes[0] = new FoodHash(this.wall);
            foodTypes[1] = new FoodDollar(this.wall);
            foodTypes[2] = new FoodAsterisk(this.wall);
            foodTypes[foodIndex].SetRandomPosition(snakeBody);
        }

        private void GetNextHeadPoint(Point direction, Point snakeHead)
        {
            this.HorX = snakeHead.HorX + direction.HorX;
            this.VerY = snakeHead.VerY + direction.VerY;
        }

        public bool IsMoving(Point direction)
        {
            Point currentSnakeHead = snakeBody.Last();
            GetNextHeadPoint(direction, currentSnakeHead);//сменя координатите на главата

            if (HorX == 0 || VerY == 0 || HorX == wall.HorX || VerY == wall.VerY || snakeBody.Any(x => x.HorX == HorX && x.VerY == VerY))
            {
                return false;
            }

            Point snakeHead = new Point(this.HorX, this.VerY);
            snakeBody.Enqueue(snakeHead);
            snakeHead.Draw(snakeSymbol);

            if (foodTypes[foodIndex].IsFoodPoint(snakeHead))
            {
                Eat(direction, currentSnakeHead);
            }
            Point snakeTail = snakeBody.Dequeue();
            snakeTail.Draw(' ');

            return true;
        }

        private void Eat(Point direction, Point currentHead)
        {
            int length = foodTypes[foodIndex].FoodPoints;
            PointsCollected += length;
            for (int i = 0; i < length; i++)
            {
                snakeBody.Enqueue(new Point(this.HorX, this.VerY));
                GetNextHeadPoint(direction, currentHead);
            }
            this.foodIndex = GetRandomIndex();
            foodTypes[foodIndex].SetRandomPosition(snakeBody);
        }

        private int GetRandomIndex()
        {
            return random.Next(0, 3);
        }
    }
}