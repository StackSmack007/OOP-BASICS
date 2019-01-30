using _09_Collection_Hierarchy.Contracts;
using _09_Collection_Hierarchy.Model;
using System;
using System.Collections.Generic;

namespace _09_Collection_Hierarchy
{
    public class Program
    {
        static void Main()
        {
            IAddCollection first = new AddCollection();
            IAddRemoveCollection second = new AddRemoveCollection();
            IMyList third = new MyList();
            string[] inputArgs = Console.ReadLine().Split();
            int numberOfRemovedItems = int.Parse(Console.ReadLine());
            AddInputLine(inputArgs, first);
            AddInputLine(inputArgs, second);
            AddInputLine(inputArgs, third);

            RemoveStuff(numberOfRemovedItems, second);
            RemoveStuff(numberOfRemovedItems, third);
                               }
        static void AddInputLine(string[] input, IAddCollection collection)
        {
            List<string> results = new List<string>();
            foreach (string word in input)
            {
                results.Add(collection.Add(word));
            }
            Console.WriteLine(string.Join(" ", results));
        }

        static void RemoveStuff(int n, IAddRemoveCollection collection)
        {
            List<string> results = new List<string>();
            for (int i = 0; i < n; i++)
            {
                results.Add(collection.Remove());
            }
            Console.WriteLine(string.Join(" ", results));
        }
    }
}