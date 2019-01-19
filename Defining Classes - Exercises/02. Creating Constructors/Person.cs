using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
   public class Person
    {
        public Person()
        {
            this.Age = 1;
            this.Name = "No name";
        }

        public Person(int age):this()
        {
            this.Age = age;
        }
        public Person(string name,int age) : this()
        {
            this.Name = name;
            this.Age = age;
        }
        
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
    }
}