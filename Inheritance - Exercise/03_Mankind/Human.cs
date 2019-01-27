using System;

namespace _03_Mankind
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string fName,string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        public string FirstName
        {
            get => firstName;
            protected set
            {
                if (!char.IsUpper(value[0])) throw new ArgumentException($"Expected upper case letter! Argument: firstName");
                if (value.Length < 4) throw new ArgumentException($"Expected length at least 4 symbols! Argument: firstName");
                firstName = value;
            }
        }

        public string LastName
        {
            get => lastName;
            protected set
            {
                if (!char.IsUpper(value[0])) throw new ArgumentException($"Expected upper case letter! Argument: lastName");
                if (value.Length < 3) throw new ArgumentException($"Expected length at least 3 symbols! Argument: lastName");
                lastName = value;
            }
        }

        public override string ToString()
        {
            return $"First Name: {FirstName}\nLast Name: {LastName}";
        }
    }
}