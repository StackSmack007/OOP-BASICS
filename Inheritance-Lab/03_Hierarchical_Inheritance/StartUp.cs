namespace Farm
{
    public class StartUp
    {
        static void Main()
        {
            Dog dog = new Dog();
            
            dog.Eat();
            dog.Bark();
            dog.SetAge(99);
            System.Console.WriteLine("Dog is "+dog.Age+ " years old!");

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}