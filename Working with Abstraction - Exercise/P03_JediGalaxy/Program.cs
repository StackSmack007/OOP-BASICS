using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class Program
    {
        static void Main()
        {
            int[] dimestions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowsGalaxy = dimestions[0];
            int colsGalaxy = dimestions[1];

            Galaxy galaxy = new Galaxy(rowsGalaxy, colsGalaxy);
            string command = Console.ReadLine();
            long collectedValue = 0;
            while (command != "Let the Force be with you")
            {
                int[] ivoBasePoint = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                Point ivoLocation = new Point(ivoBasePoint[0], ivoBasePoint[1]);
                ivoLocation.NormalizeForIvoPath(rowsGalaxy, colsGalaxy);

                int[] evilBasePoint = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                Point evilLocation = new Point(evilBasePoint[0], evilBasePoint[1]);

                evilLocation.NormalizeForEvilPath(rowsGalaxy, colsGalaxy);
                galaxy.EvilPath(evilLocation);
                collectedValue += galaxy.IvoPath(ivoLocation);

                command = Console.ReadLine();
            }
            Console.WriteLine(collectedValue);
        }
    }
}