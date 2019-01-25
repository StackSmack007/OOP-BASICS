using System;

namespace Farm
{
    public abstract  class Animal
    {
        public int Age { get; protected set; }
        public void Eat()
        {
            Console.WriteLine("eating...");
        }
    }
}