namespace AnimalPlanet
{
    class Cat:Animal, InterFace
    {
        public Cat(string name, int age, string gender) : base(name, age, gender) { }

        public virtual string ProduceSound()
        {
            return "Meow meow";
        }
    }
}
