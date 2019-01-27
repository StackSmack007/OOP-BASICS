namespace AnimalPlanet
{
    class Dog:Animal, InterFace
    {
        public Dog(string name, int age, string gender) : base(name, age, gender) { }

        public string ProduceSound()
        {
            return "Woof!";
        }
    }
}
