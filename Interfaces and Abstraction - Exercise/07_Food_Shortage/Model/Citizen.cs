using BorderControl.Contracts;

namespace BorderControl.Model
{
    public class Citizen : DataOfHuman,IBuyer
    {
        private int age;
        private string birthDay;
        public Citizen(string name, int age, string id, string birthDay) : base(name, id)
        {
            this.age = age;
            BirthDay = birthDay;
        }

        public string BirthDay { get => birthDay; private set => birthDay = value; }

        public int Food { get; private set; } =0;

        public void BuyFood()
        {
            Food += 10;
        }
    }
}