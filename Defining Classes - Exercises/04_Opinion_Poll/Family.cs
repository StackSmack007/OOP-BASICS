using System.Collections.Generic;
using System.Linq;

namespace _04_Opinion_Poll
{
    public class Family
    {
        public Family()
        {
            members = new List<Person>();
        }
        private List<Person> members;

        public void AddPerson(string input)
        {
            string[] inputArr = input.Split(' ');
            Person member = new Person(int.Parse(inputArr[1]), inputArr[0]);
            members.Add(member);
        }
        public List<Person> GetOlderThan30()
        {
            return members.Where(x=>x.Age>30).OrderBy(x => x.Name).ToList();
        }
    }
}