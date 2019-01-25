using System;

namespace Farm
{
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("barking...");
        }
        public void SetAge(int age)
        {
            Age = age;
        }
    }
}