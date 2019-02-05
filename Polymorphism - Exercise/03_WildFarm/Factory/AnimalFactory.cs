using System;

namespace WildFarm.Factory
{
    using Model.Animal;
    using WildFarm.Model.Animal.Mammal;
    using WildFarm.Model.Animal.Mammal.Bird;
    using WildFarm.Model.Animal.Mammal.Feline;

    public class AnimalFactory
    {
        public Animal Produce(string[] inputArgs)
        {
            string type = inputArgs[0];
            string name = inputArgs[1];
            double weight = double.Parse(inputArgs[2]);
            //•	Felines - "{Type} {Name} {Weight} {LivingRegion} {Breed}";
            //•	Birds - "{Type} {Name} {Weight} {WingSize}";
            //•	Mice and Dogs - "{Type} {Name} {Weight} {LivingRegion}";
            try
            {
            if (type=="Cat"||type=="Tiger")
            {
                string region = inputArgs[3];
                string breed = inputArgs[4];
                if (type=="Cat")return new Cat(name,weight,region,breed);
                if (type=="Tiger")return new Tiger(name,weight,region,breed);
            }
            if (type == "Dog" || type == "Mouse")
            {
                string region = inputArgs[3];
                if (type == "Dog") return new Dog(name, weight, region);
                if (type == "Mouse") return new Mouse(name, weight, region);
            }
            if (type == "Owl" || type == "Hen")
            {
                double wingSize = double.Parse(inputArgs[3]);
                if (type == "Owl") return new Owl(name, weight, wingSize);
                if (type == "Hen") return new Hen(name, weight, wingSize);
            }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            return null;
        }
    }
}