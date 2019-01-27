namespace AnimalFarm.Animals
{
    class Frog:Animal
    {
        public Frog(string name, string age, string gender) : base(name, age, gender) { }
        public override string MakeASound()
        {
            return "Ribbit";
        }
    }
}