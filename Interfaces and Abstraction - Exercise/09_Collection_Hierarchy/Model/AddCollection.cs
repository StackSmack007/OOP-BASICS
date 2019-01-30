using _09_Collection_Hierarchy.Contracts;
using System.Collections.Generic;

namespace _09_Collection_Hierarchy.Model
{
    public class AddCollection : List<string>, IAddCollection
    {
        public virtual string Add(string element)
        {
            base.Add(element);
            return LastIndexOf(element).ToString();
        }
    }
}