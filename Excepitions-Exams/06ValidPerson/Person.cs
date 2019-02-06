using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06ValidPerson
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "The first name cannot be null or empty");
                }
                if (value.Any(x => char.IsDigit(x)))
                {
                    throw new ErrorMaden("bad numbers are doing wrong", "in the first name possible");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "The last name cannot be null or empty");
                }
                if (value.Any(x => char.IsDigit(x)))
                {
                    throw new ErrorMaden("bad numbers are doing wrong", "in the last name possible");
                }
                lastName = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Age should be in the range [0 ... 120].");
                }
                age = value;
            }
        }
    }
}