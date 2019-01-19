using System;
namespace _13_Family_Tree
{
    public class Person
    {
        public Person() { this.Status = "n/a"; }//withNothing
        public Person(string names, string birthDate) : this()//withAll
        {
            this.Names = names;
            this.BirthDate = birthDate;

        }
        public Person(string names):this()//withOnlyName
        {
            this.names = names;
        }

        string names;
        string status;
        string birthDate;

        public string Names
        {
            get { return this.names; }
            set { this.names = value; }
        }
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }
        public string BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }
    }
}