using System;
using System.Collections.Generic;

namespace AnimalPlanet
{
    public class Animal
    {
        protected string name;
        protected int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            protected set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("Invalid input!");
                }
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                age = value;
            }
        }

        public string Gender
        {
            get => gender;
            protected set
            {
                if (value.ToLower() != "male" && value.ToLower() != "female")
                {
                    throw new ArgumentException("Invalid input!");
                }
                gender = value;
            }
        }

        public string GetNameAgeGender()
        {
            return $"{Name} {Age} {Gender}";
        }

    }
}