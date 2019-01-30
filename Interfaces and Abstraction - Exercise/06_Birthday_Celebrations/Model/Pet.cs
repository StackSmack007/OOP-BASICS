using BorderControl.Contracts;

namespace BorderControl.Model
{
    public class Pet : IBirthable
    {
        private string birthDay;
        public string Name { get; private set; }
        public Pet(string name, string birthDay)
        {
            Name = name;
            BirthDay = birthDay;
        }
        public string BirthDay { get => birthDay; set => birthDay = value; }
    }
}