using AnimalFarm.Animals;
namespace AnimalFarm.Factories
{
    public class AnimalFactory
    {

        public Animal Produce(string type, string input)
        {
            string[] inputArgs = input.Split(' ',System.StringSplitOptions.RemoveEmptyEntries);
            string name = inputArgs[0];
            string age = inputArgs[1];
            string gender = inputArgs.Length == 3 ? inputArgs[2] : null;
            switch (type)
            {
                case "Dog": return new Dog(name, age, gender);
                case "Frog": return new Frog(name, age, gender);
                case "Cat": return new Cat(name, age, gender);
                case "Kitten": return new Kitten(name, age);
                case "Tomcat": return new TomCat(name, age);
                default: Animal.Error(); break;
            }
            return null;
        }
    }
}