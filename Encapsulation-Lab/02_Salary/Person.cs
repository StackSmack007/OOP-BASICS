using System;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;
        public Person(string firstName,string lastName, int age,decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public decimal Salary { get => salary; set => salary = value; }

        public void IncreaseSalary(decimal percentage)
        {
            decimal raise = this.Salary;
            if (this.Age<30)
            {
                 raise*=percentage/ 200.0m;    
            }
            else
            {
                raise *= percentage / 100.0m;
            }
            this.Salary += raise;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {Salary:F2} leva.";
        }
    }
}