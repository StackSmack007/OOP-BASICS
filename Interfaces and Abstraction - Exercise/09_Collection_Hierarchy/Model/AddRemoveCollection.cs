using _09_Collection_Hierarchy.Contracts;

namespace _09_Collection_Hierarchy.Model
{
    public class AddRemoveCollection : AddCollection,IAddRemoveCollection
    {
        public override string Add(string element)
        {
            base.Insert(0, element);
            return IndexOf(element).ToString();
        } 
        public virtual string Remove()
        {
            string element = this[Count - 1];
            RemoveAt(Count - 1);
            return element;
        }
    }
}