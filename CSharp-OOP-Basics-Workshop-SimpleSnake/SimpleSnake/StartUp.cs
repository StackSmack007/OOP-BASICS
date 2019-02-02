namespace SimpleSnake
{
    using Utilities;
    using Core;
    using SimpleSnake.GameObjects;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();

            Wall wall = new Wall(60,80);
            Snake snake = new Snake(wall);

            Engine engine = new Engine(wall,snake);
            engine.Run();

        }
    }
}