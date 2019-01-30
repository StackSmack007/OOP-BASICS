using _09_Collection_Hierarchy.Contracts;

namespace _09_Collection_Hierarchy.Model
{
    public class MyList : AddRemoveCollection, IMyList
    {
        public void Used()
        {
            System.Console.WriteLine(string.Join(" ",this));
        }
        public override string Remove()
        {

            string element = this[0];
            base.RemoveAt(0);
            return element;

            
        }

    }
}