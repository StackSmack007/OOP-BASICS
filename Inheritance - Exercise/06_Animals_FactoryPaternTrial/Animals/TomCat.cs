namespace AnimalFarm.Animals
{
    class TomCat:Cat
    {
        private const string gender = "Male";
        public TomCat(string name, string age) : base(name, age, gender) { }
        public override string MakeASound()
        {
            return "MEOW";
        }
    }
}