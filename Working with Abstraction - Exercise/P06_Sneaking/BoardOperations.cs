using System;
using System.Linq;

namespace P06_Sneaking
{
    public static class BoardOperations
    {
        private static char[][] Board { get; set; }

        public static void CreateBoard(int n)
        {
            Board = new char[n][];
            for (int i = 0; i < n; i++)
            {
                Board[i] = Console.ReadLine().ToCharArray();
            }
        }
        public static void EnemiesMove()
        {
            for (int i = 0; i < Board.Length; i++)
            {
                if (Board[i].Contains('b'))
                {
                    int index = Array.FindIndex(Board[i], x => x == 'b');
                    if (index == Board[i].Length - 1)
                    {
                        Board[i][index] = 'd';
                    }
                    else
                    {
                        Board[i][index] = '.';
                        Board[i][index + 1] = 'b';
                    }
                }
                else if (Board[i].Contains('d'))
                {
                    int index = Array.FindIndex(Board[i], x => x == 'd');
                    if (index == 0)
                    {
                        Board[i][index] = 'b';
                    }
                    else
                    {
                        Board[i][index] = '.';
                        Board[i][index - 1] = 'd';
                    }
                }
            }
        }

        public static void SamMove(char direction)
        {
            (var SamRow, var SamCol) = SamLocation();      
            CheckForOutCome();
            Board[SamRow][SamCol] = '.';
            switch (direction.ToString().ToUpper())
            {
                case ("U"): SamRow--; break;
                case ("D"): SamRow++; break;
                case ("L"): SamCol--; break;
                case ("R"): SamCol++; break;
            }
            Board[SamRow][SamCol] = 'S';
            CheckForOutCome();
        }

        private static void CheckForOutCome()
        {
            (var SamRow, var SamCol) = SamLocation();
            int nikoladzeIndex = Array.FindIndex(Board[SamRow], x => x == 'N');
            int b_Index = Array.FindIndex(Board[SamRow], x => x == 'b');
            int d_Index = Array.FindIndex(Board[SamRow], x => x == 'd');

            if (nikoladzeIndex != -1)
            {
                Board[SamRow][nikoladzeIndex] = 'X';
                Console.WriteLine("Nikoladze killed!");
                PrintArray();
            }
            if ((b_Index != -1 && b_Index < SamCol) || d_Index > SamCol)
            {
                Board[SamRow][SamCol] = 'X';
                Console.WriteLine($"Sam died at {SamRow}, {SamCol}");
                PrintArray();
            }
        }

        private static (int, int) SamLocation()
        {
            for (int i = 0; i < Board.Length; i++)
            {
                for (int j = 0; j < Board[i].Length; j++)
                {
                    if (Board[i][j] == 'S')
                    {
                        return (i, j);
                    }
                }
            }
            return (-1,-1);
        }

        public static void PrintArray()
        {
            foreach (var rowArr in Board)
            {
                Console.WriteLine(string.Join("", rowArr));
            };
            Environment.Exit(0);
        }
    }
}