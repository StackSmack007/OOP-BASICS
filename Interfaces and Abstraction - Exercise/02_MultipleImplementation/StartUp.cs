using System;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            var id = Console.ReadLine();
            var birthdate = Console.ReadLine();

            IIdentifiable person1 = new Citizen(name,age,id, birthdate);
            IBirthable person2 = new Citizen(name, age, id, birthdate);

            Console.WriteLine(person1.Id);
            Console.WriteLine(person2.Birthdate);
        }
    }
}