using System;

namespace _03_Mankind
{
  public  class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }
        private Action<string> ValueMismatch = x => throw new ArgumentException($"Expected value mismatch! Argument: {x}");
        public decimal WeekSalary
        {
            get => weekSalary;
            set
            {
                if (value <= 10) ValueMismatch("weekSalary");
                weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get => workHoursPerDay;
            set
            {
                if (value < 1 || value > 12) ValueMismatch("workHoursPerDay");
                workHoursPerDay = value;
            }
        }

        private decimal GetHourPay()
        {
            return weekSalary / (5 * (decimal)workHoursPerDay);
        }

        public override string ToString()
        {
            return $"First Name: {FirstName}\nLast Name: {LastName}\nWeek Salary: {WeekSalary:F2}\nHours per day: {workHoursPerDay:F2}\nSalary per hour: {GetHourPay():F2}";
        }
    }
}