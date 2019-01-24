using System;
using System.Collections.Generic;

namespace _06_Football_Team_Generator
{
   internal class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        
        public Player(string name, Queue<int> stats)
        {
            this.Name = name;
            this.Endurance = stats.Dequeue();
            this.Sprint = stats.Dequeue();
            this.Dribble = stats.Dequeue();
            this.Passing = stats.Dequeue();
            this.Shooting = stats.Dequeue();
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

        public int Endurance
        {
            get => endurance;
            private set
            {
                ExceptionInvalidStat(value, "Endurance");
                this.endurance = value;
            }
        }

        public int Sprint
        {
            get => sprint;
            private set
            {
                ExceptionInvalidStat(value, "Sprint");
                this.sprint = value;
            }
        }

        public int Dribble
        {
            get => dribble;
            private set
            {
                ExceptionInvalidStat(value, "Dribble");
                this.dribble = value;
            }
        }

        public int Passing
        {
            get => passing;
            private set
            {
                ExceptionInvalidStat(value, "Passing");
                this.passing = value;
            }
        }

        public int Shooting
        {
            get => shooting;
            private set
            {
                ExceptionInvalidStat(value, "Shooting");
                this.shooting = value;
            }
        }

        private void ExceptionInvalidStat(int value, string type)
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{type} should be between 0 and 100.");
            }
        }

        public double AverageStat()
        {
            return (Passing + Shooting + Sprint + Dribble + Endurance) / 5.0;
        }
    }
}