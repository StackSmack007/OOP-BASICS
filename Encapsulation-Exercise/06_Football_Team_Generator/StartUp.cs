using System;
using System.Collections.Generic;

namespace _06_Football_Team_Generator
{
   public class StartUp
    {
        static void Main()
        {
            List<Team> teams = new List<Team>();
            string[] input;
            while ((input=Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries))[0]!="END")
            {
                string command = input[0];
                string teamName = input[1];
                int teamIndex = teams.FindIndex(x => x.Name == teamName);
                try
                {       
                    if (command.ToLower()=="team")
                    {
                        if (teamIndex != -1) throw new ArgumentException($"Team {teamName} already exist.");
                        teams.Add(new Team(teamName));
                        continue;
                    }

                    if (command.ToLower()=="add")
                    {
                        if (teamIndex==-1) throw new ArgumentException($"Team {teamName} does not exist.");                
                        teams[teamIndex].AddPlayer(input);
                    }

                    if (command.ToLower() == "remove")
                    {
                        string playerName = input[2];
                        if (teamIndex == -1) throw new ArgumentException($"Team {teamName} does not exist.");
                        teams[teamIndex].RemovePlayer(playerName);
                    }

                    if (command.ToLower()=="rating")
                    {
                        if (teamIndex == -1) throw new ArgumentException($"Team {teamName} does not exist.");
                        Console.WriteLine(teams[teamIndex]);
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }
    }
}