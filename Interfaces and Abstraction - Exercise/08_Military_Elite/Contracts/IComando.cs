using Military.Model;
using System.Collections.Generic;

namespace Military.Contracts
{
    public interface IComando
    {
       IReadOnlyCollection<Mission> Missions { get; }

    }
}