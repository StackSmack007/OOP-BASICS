namespace AnimalFarm.Animals
{
    class Kitten : Cat
    {
        private const string gender = "Female";
        public Kitten(string name, string age) : base(name, age, gender) { }
        public override string MakeASound()
        {
            return "Meow";
        }
    }
}