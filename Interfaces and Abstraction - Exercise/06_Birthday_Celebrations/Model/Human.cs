using BorderControl.Contracts;

namespace BorderControl.Model
{
    public class Human : Robot, IBirthable
    {
        private int age;
        private string birthDay;
        public Human(string name, int age, string id, string birthDay) : base(name, id)
        {
            this.age = age;
            BirthDay = birthDay;
        }

        public string BirthDay { get => birthDay; private set => birthDay = value; }
    }
}