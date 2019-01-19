using System;
using System.Collections.Generic;
using System.Text;

namespace _13_Family_Tree_2ndAproach
{
    public class Person
    {
        public Person() { }

        public Person(string names, string birthDate)
        {
            this.Names = names;
            this.BirthDate = birthDate;
        }
        string names;
        string birthDate;
        List<Person> parents;
        List<Person> children;

        public List<Person> Parents
        {
            get { return this.parents; }
            set { this.parents = value; }
        }
        public List<Person> Children
        {
            get { return this.children; }
            set { this.children = value; }
        }
        
        public string Names
        {
            get { return this.names; }
            set { this.names = value; }
        }

        public string BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }
    }
}