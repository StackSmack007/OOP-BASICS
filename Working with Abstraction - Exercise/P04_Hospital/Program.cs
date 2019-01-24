using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Program
    {
        public static void Main()
        {
            List<Department> departments = new List<Department>();
            string[] input;
            while ((input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries))[0] != "Output")
            {
                string department = input[0];
                string doctor = input[1] + ' ' + input[2];
                string patient = input[3];
                if (!departments.Any(x=>x.Name==department))
                {
                    departments.Add(new Department(department));
                }

                var currentDepartment = departments.FirstOrDefault(x => x.Name == department);
                currentDepartment.AddPatient(patient,doctor);
            }

            while ((input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries))[0] != "End")
            {
                Department.Print(departments,input);
            }
        }
    }
}