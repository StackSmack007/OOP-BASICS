using System.Collections.Generic;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.Name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public string Name { get => name;private set => name = value; }
        public IReadOnlyCollection<Person> FirstTeam { get => firstTeam;  }
        public IReadOnlyCollection<Person> ReserveTeam { get => reserveTeam; }

        public void AddPlayer(Person person)
        {
            if (person.Age<40)
            {
                firstTeam.Add(person);
                return;
            }
            reserveTeam.Add(person);
        }
    }
}
