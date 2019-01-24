using System;
namespace P06_Sneaking
{
    public class StartUp
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            BoardOperations.CreateBoard(rows);
            char[] directions = Console.ReadLine().ToCharArray();
            foreach (char direction in directions)
            {
                BoardOperations.EnemiesMove();
                BoardOperations.SamMove(direction);
            }
        }
    }
}