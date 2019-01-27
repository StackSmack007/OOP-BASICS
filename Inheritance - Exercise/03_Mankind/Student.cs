using System;
using System.Linq;

namespace _03_Mankind
{
  public  class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facNumber) : base(firstName, lastName)
        {
            FacultyNumber = facNumber;
        }

        public string FacultyNumber
        {
            get => facultyNumber;
            set
            {
                if (value.Length < 5 || value.Length > 10||!value.All(x=>char.IsLetterOrDigit(x))) throw new ArgumentException("Invalid faculty number!");
                facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return $"First Name: {FirstName}\nLast Name: {LastName}\nFaculty number: {FacultyNumber}";
        }
    }
}