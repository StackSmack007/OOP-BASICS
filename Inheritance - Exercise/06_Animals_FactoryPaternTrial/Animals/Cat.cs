namespace AnimalFarm.Animals
{
    class Cat : Animal
    {
        public Cat(string name, string age, string gender) : base(name, age, gender) { }
        public override string MakeASound()
        {
            return "Meow meow";
        }
    }
}