using System;
using System.Linq;

namespace _09_Rectangle_Intersection
{
    class Program
    {
        static void Main()
        {
            int[] n_n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle[] recs = new Rectangle[n_n[0]];
            for (int i = 0; i < n_n[0]; i++)
            {
                recs[i] = new Rectangle(Console.ReadLine());
            }
            for (int i = 0; i < n_n[1]; i++)
            {
                string[] input = Console.ReadLine().Split();
                recs.FirstOrDefault(x => x.Id == input[0]).Check(recs.FirstOrDefault(x => x.Id == input[1]));
            }
        }
    }
}