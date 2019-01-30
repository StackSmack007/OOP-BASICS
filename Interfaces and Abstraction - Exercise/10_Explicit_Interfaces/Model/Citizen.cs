using ExplicitInterfaces.Contracts;
using System;

namespace ExplicitInterfaces.Model
{
    public class Citizen : IResident, IPerson
    {
        private string name;
        private int age;
        private string country;

        public Citizen(string name, string country, int age)
        {
            Name = name;
            Age = age;
            this.country = country;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        string IResident.Name
        {
            get
            {
                return this.name;
            }
            set
            {
                name = value;
            }
        }

        string IResident.Country
        {
            get
            {
                return this.country;
            }
            set
            {
                country = value;
            }
        }

        public void GetName()
        {
            Console.WriteLine(this.Name); 
        }

        void IResident.GetName()
        {
            Console.WriteLine("Mr/Ms/Mrs " + this.Name);
        }
    }
}