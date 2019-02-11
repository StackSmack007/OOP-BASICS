using System;
using System.Linq;

namespace DungeonsAndCodeWizards.Core
{
    public class Engine
    {
        private DungeonMaster dg;

        public Engine()
        {
            dg = new DungeonMaster();
        }
        public void Run()
        {
            while (true)
            {
                try
                {
                    string inputLine = Console.ReadLine();
                    if (string.IsNullOrEmpty(inputLine))
                    {
                        Console.WriteLine("Final stats:");
                        Console.Write(dg.GetStats());
                        break;
                    }
                    string[] input = inputLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string command = input[0].ToLower();

                    input = input.Skip(1).ToArray();
                    switch (command)
                    {
                        case "joinparty": Console.WriteLine(dg.JoinParty(input)); break;
                        case "additemtopool": Console.WriteLine(dg.AddItemToPool(input)); break;
                        case "pickupitem": Console.WriteLine(dg.PickUpItem(input)); break;
                        case "useitem": Console.WriteLine(dg.UseItem(input)); break;
                        case "useitemon": Console.WriteLine(dg.UseItemOn(input)); break;
                        case "givecharacteritem": Console.WriteLine(dg.GiveCharacterItem(input)); break;
                        case "getstats": Console.WriteLine(dg.GetStats()); break;
                        case "heal": Console.WriteLine(dg.Heal(input)); break;
                        case "attack": Console.WriteLine(dg.Attack(input)); break;
                        case "endturn": Console.WriteLine(dg.EndTurn(input)); break;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine($"Parameter Error: {ae.Message}");
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine($"Invalid Operation: {ioe.Message}");
                }
                if (dg.IsGameOver())
                {
                    Console.WriteLine("Final stats:");
                    Console.Write(dg.GetStats());
                    break;
                }
            }
        }
    }
}