using System;

namespace DefiningClasses
{
   public class StartUp
    {
        static void Main()
        {
            Person human1 = new Person(13, "Maria");

            Console.WriteLine(human1.Name+" "+human1.Age);
        }
    }
}
