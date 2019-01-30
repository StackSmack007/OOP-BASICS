using Military.Model;
using System.Collections.Generic;
namespace Military.Contracts
{
    public interface IEngineer
    {
        IReadOnlyCollection<Repair> Repairs { get; }
    }
}