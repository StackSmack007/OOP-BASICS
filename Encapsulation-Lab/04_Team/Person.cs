using System;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                NameChecker(value, "First");
                firstName = value;
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                NameChecker(value, "Last");
                lastName = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                age = value;
            }
        }

        public decimal Salary
        {
            get => salary;
            set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
                this.salary = value;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            decimal raise = this.Salary;
            if (this.Age < 30)
            {
                raise *= percentage / 200.0m;
            }
            else
            {
                raise *= percentage / 100.0m;
            }
            this.Salary += raise;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} gets {Salary:F2} leva.";
        }

        public void NameChecker(string input, string nameType)
        {
            if (input.Length < 3)
            {
                throw new ArgumentException($"{nameType} name cannot contain fewer than 3 symbols!");
            }
        }
    }
}