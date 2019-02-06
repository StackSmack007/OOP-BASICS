using System;

namespace _06ValidPerson
{
    public class StartUp
    {
        static void Main()
        {
            string fname = Console.ReadLine();
            string lname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            try
            {
                Person pesho = new Person(fname, lname, age);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("Exception thrown: {0}", ane.Message);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                Console.WriteLine("Exception thrown: {0}", aoore.Message);
            }
            catch (ErrorMaden em)
            {
                Console.WriteLine($"Exception thrown:  {em.Message} [{em.Clarification}]\nWhy is that?");
                em.WhoAmI();
            }
        }
    }
}