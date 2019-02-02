using System;

namespace SimpleSnake.Core
{
    using Enums;
    using GameObjects;
    using System.Threading;

    public class Engine
    {
        private Wall wall;
        private Point[] pointsOfDirections;
        private Direction direction;
        private Snake snake;
        private double sleepTime;

        public Engine(Wall wall, Snake snake)
        {
            this.wall = wall;
            this.snake = snake;
            this.sleepTime = 100;
            pointsOfDirections = new Point[4];
        }

        private void CreateDirections()
        {
            this.pointsOfDirections[0] = new Point(1, 0);   // right
            this.pointsOfDirections[1] = new Point(-1, 0);  //left
            this.pointsOfDirections[2] = new Point(0, 1);   //down
            this.pointsOfDirections[3] = new Point(0, -1);  //up
        }

        private void GetNextDirection()
        {
            ConsoleKeyInfo userInput = Console.ReadKey();
            bool horizontalMove = direction == Direction.Right || direction == Direction.Left;
            bool verticalMove = direction == Direction.Up || direction == Direction.Down;
            if (horizontalMove)
            {
                if (userInput.Key == ConsoleKey.UpArrow)
                {
                    direction = Direction.Up;
                }
                else if (userInput.Key == ConsoleKey.DownArrow)
                {
                    direction = Direction.Down;
                }
            }

            if (verticalMove)
            {
                if (userInput.Key == ConsoleKey.LeftArrow)
                {
                    direction = Direction.Left;
                }
                else if (userInput.Key == ConsoleKey.RightArrow)
                {
                    direction = Direction.Right;
                }
            }
            Console.CursorVisible = false;
        }

        public void Run()
        {
            CreateDirections();
            while (true)
            {
                Score();

                if (Console.KeyAvailable)
                {
                    GetNextDirection();
                }

                bool isMoving = snake.IsMoving(pointsOfDirections[(int)direction]);
                if (!isMoving)
                {
                    AskUserForRestart();
                }
                sleepTime -= 0.01;
                Thread.Sleep((int)sleepTime);
            }
        }

        public void Score()
        {
            Console.SetCursorPosition(this.wall.HorX + 3, 10);
            Console.WriteLine("Player Score:");
            Console.SetCursorPosition(this.wall.HorX + 3, 11);
            Console.WriteLine($"Points: {this.snake.PointsCollected}");
            Console.SetCursorPosition(this.wall.HorX + 3, 12);
            Console.WriteLine($"Level: {this.snake.PointsCollected / 10}");
            if (this.snake.PointsCollected / 10 < 1)
            {
                Console.SetCursorPosition(this.wall.HorX + 3, 14);
                Console.WriteLine("\"So far so good...\"");
            }
            else if (this.snake.PointsCollected / 10 < 2)
            {
                Console.SetCursorPosition(this.wall.HorX + 3, 14);
                Console.WriteLine("\"You are the man!...\"");
            }
            else if (this.snake.PointsCollected / 10 < 3)
            {
                Console.SetCursorPosition(this.wall.HorX + 3, 14);
                Console.WriteLine("\"Ибаааси змиътъ...\" (Краси Радков)");
            }
            else
            {
                Console.SetCursorPosition(this.wall.HorX + 3, 14);
                Console.WriteLine("\"От Гиза до Мароко - Само Локо!...\" (Хеопс)");
            }
        }


        private void AskUserForRestart()
        {
            int HX = this.wall.HorX + 1;
            int VY = 3;

            Console.SetCursorPosition(HX, VY);
            Console.WriteLine("Would you like to continue? y/n");
            string input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                Console.Clear();
                StartUp.Main();
            }
            else
            {
                StopGame();
            }
        }

        private void StopGame()
        {
            Console.SetCursorPosition(20, 10);
            Console.Write("Game over!");
            Environment.Exit(0);
        }
    }
}