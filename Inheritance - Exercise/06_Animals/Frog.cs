namespace AnimalPlanet
{
    public class Frog:Animal,InterFace
    {
        public Frog(string name, int age, string gender) : base(name, age, gender) { }

        public string ProduceSound()
        {
            return "Ribbit";
        }
    }
}
