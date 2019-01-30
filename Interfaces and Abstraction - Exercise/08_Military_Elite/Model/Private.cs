using Military.Contracts;
namespace Military.Model
{
    public class Private : Soldier,IPrivate
    {
        private decimal salary;

        public Private(string firstName, string lastName, string id, decimal salary) : base(firstName, lastName, id)
        {
            Salary = salary;
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }
            private set
            {
                salary = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}\n";
        }

    }
}