using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_Google
{
    public class Person
    {
        private string name;
        private Company company;
        private Car car;
        private List<Pokemon> pokemons;
        private List<FamilyMember> familyMembers;
        public Person(string name)
        {
            this.Name = name;
            this.Pokemons = new List<Pokemon>();
            this.FamilyMembers = new List<FamilyMember>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Company Company
        {
            get { return company; }
            set { company = value; }
        }

        public Car Car
        {
            get { return car; }
            set { car = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }

        public List<FamilyMember> FamilyMembers
        {
            get { return familyMembers; }
            set { familyMembers = value; }
        }

        public void Print()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine("Company:");
            if (this.Company != null) Console.WriteLine($"{Company.Name} {Company.Department} {Company.Salary:F2}");
            Console.WriteLine("Car:");
            if (this.Car != null) Console.WriteLine($"{Car.Model} {Car.CarSpeed}");
            Console.WriteLine("Pokemon:");
            foreach (Pokemon pokemon in Pokemons)
            {
                Console.WriteLine($"{pokemon.Name} {pokemon.Type}");
            }
            Console.WriteLine("Parents:");
            foreach (FamilyMember member in FamilyMembers.Where(x => x.Relation.ToLower() == "parents"))
            {
                Console.WriteLine($"{member.Name} {member.BirthDate}");
            }
            Console.WriteLine("Children:");
            foreach (FamilyMember member in FamilyMembers.Where(x => x.Relation.ToLower() == "children"))
            {
                Console.WriteLine($"{member.Name} {member.BirthDate}");
            }
        }
    }
}