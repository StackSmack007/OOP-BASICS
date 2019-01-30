using Military.Model;
using System.Collections.Generic;

namespace Military.Contracts
{
    public interface ILieutenantGeneral
    {
        IReadOnlyCollection<Soldier> PrivatesUnder { get; }
    }
}