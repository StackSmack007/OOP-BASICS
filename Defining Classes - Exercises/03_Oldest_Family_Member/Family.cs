using System.Collections.Generic;
using System.Linq;

namespace nameSpace03
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
        public Person GetOldest()
        {
            return members.OrderByDescending(x=>x.Age).FirstOrDefault();
        }
    }
}