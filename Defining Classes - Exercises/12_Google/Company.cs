using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Google
{
    public class Company
    {
        private string name;
        private string department;
        private decimal salary;
        public Company(string[] input)
        {
            this.Name = input[2];
            this.Department = input[3];
            this.Salary = decimal.Parse(input[4]);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

    }
}