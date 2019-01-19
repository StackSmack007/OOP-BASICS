
namespace _04_Opinion_Poll
{
    public class Person
    {
        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
        private int age;
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
