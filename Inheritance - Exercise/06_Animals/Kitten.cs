namespace AnimalPlanet
{
    class Kitten:Cat, InterFace
    {
        public Kitten(string name, int age) : base(name, age, "Female") { }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}