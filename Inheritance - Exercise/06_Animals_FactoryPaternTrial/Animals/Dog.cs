namespace AnimalFarm.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string age, string gender) : base(name, age, gender) { }
        public override string MakeASound()
        {
            return "Woof!";
        }
    }
}