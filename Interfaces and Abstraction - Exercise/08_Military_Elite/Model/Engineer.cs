using Military.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Military.Model
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private readonly List<Repair> repairs;
        public Engineer(string firstName, string lastName, string id, decimal salary, string corpus,List<Repair> repairs) :base(firstName,lastName,id,salary,corpus)
        {
            this.repairs = repairs;
        }

        public IReadOnlyCollection<Repair> Repairs
        {
            get
            {
                return repairs;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            sb.AppendLine($"Corps: {Corpus}");
            sb.AppendLine($"Repairs:");
            if (Repairs != null) Repairs.ToList().ForEach(x => sb.AppendLine("  "+x.ToString()));
            return sb.ToString();
        }
    }
}