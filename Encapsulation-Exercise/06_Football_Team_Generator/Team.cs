using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Football_Team_Generator
{
    internal class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        public IReadOnlyCollection<Player> Players
        {
            get => players;
        }

        public void AddPlayer(string[] input)
        {
            string name = input[2];
            Queue<int> stats = new Queue<int>(input.Skip(3).Select(int.Parse));
            Player player = new Player(name, stats);

            this.players.RemoveAll(x => x.Name == name);//check?

            this.players.Add(player);
        }

        public void RemovePlayer(string name)
        {
           Player player = players.FirstOrDefault(x => x.Name == name);
            if (player is null)
            {
                throw new ArgumentException($"Player {name} is not in {this.Name} team.");
            }
            players.Remove(player);
        }

        private int GetRating()
        {
            if (Players.Count==0)
            {
                return 0;
            }
            return (int)Math.Round(this.Players.Average(x => x.AverageStat()));
        }

        public override string ToString()
        {
            return $"{this.Name} - {GetRating()}";
        }
    }
}