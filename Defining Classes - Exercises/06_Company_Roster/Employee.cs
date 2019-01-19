using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Company_Roster
{
    public class Employee
    {
        public Employee()
        {

        }
        public Employee(string name, decimal salary, string position, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Age = -1;
            this.Email = "n/a";
        }
        public Employee(string name, decimal salary, string position, string department, int age) : this(name, salary, position, department)
        {
            this.Age = age;
        }
        public Employee(string name, decimal salary, string position, string department, string email) : this(name, salary, position, department)
        {
            this.Email = email;
        }
        public Employee(string name, decimal salary, string position, string department, string email, int age) : this(name, salary, position, department, age)
        {
            this.Email = email;
        }

        string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        decimal salary;
        public decimal Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }
        string position;
        public string Position
        {
            get { return this.position; }
            set { this.position = value; }
        }
        string department;
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }
        string email;
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        int age;
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
    }
}