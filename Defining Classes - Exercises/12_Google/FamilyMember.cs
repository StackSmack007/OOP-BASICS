using System;
using System.Globalization;

namespace _12_Google
{
    public class FamilyMember
    {
        private string relation;
        private string name;
        private string birthDate;

        public FamilyMember(string[] input)
        {
            this.Relation = input[1];
            this.Name = input[2];
            this.BirthDate = input[3];
        }

        public string Relation
        {
            get { return relation; }
            set { relation = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
    }
}