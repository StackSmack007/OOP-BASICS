using Military.Contracts;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Military.Model
{
    public class Comando : SpecialisedSoldier, IComando
    {
        private readonly List<Mission> missions;
        public Comando(string firstName, string lastName, string id, decimal salary, string corpus,List<Mission> missions) :base(firstName,lastName,id,salary,corpus)
        {
            this.missions = missions;
        }

        public IReadOnlyCollection<Mission> Missions
        {
            get
            {
                return missions;
            }
        }

        public object Repairs { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            sb.AppendLine($"Corps: {Corpus}");
            sb.AppendLine($"Missions:");
            if (Missions!=null) Missions.ToList().ForEach(x => sb.AppendLine($"  {x.ToString()}"));
            return sb.ToString();
        }
    }
}