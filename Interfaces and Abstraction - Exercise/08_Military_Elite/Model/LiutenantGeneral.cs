using Military.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Military.Model
{
    public class LiutenantGeneral : Private, ILieutenantGeneral
    {
        readonly List<Soldier> privatesUnder;

        public LiutenantGeneral(string firstName, string lastName, string id, decimal salary,List<Soldier> privates) : base(firstName, lastName, id, salary)
        {
            privatesUnder = privates;
        }

        public IReadOnlyCollection<Soldier> PrivatesUnder
        {
            get
            {
                return privatesUnder;
            }
        }   

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            sb.AppendLine($"Privates:");
            PrivatesUnder.ToList().ForEach(x => sb.Append("  "+x.ToString()));
            return sb.ToString();
        }
    }
}