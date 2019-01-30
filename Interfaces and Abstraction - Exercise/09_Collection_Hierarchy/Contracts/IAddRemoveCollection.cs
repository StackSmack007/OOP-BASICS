namespace _09_Collection_Hierarchy.Contracts
{
    public interface IAddRemoveCollection:IAddCollection
    {

        /// <summary>
        /// Removes the last element of the collection!
        /// </summary>
        /// <param name="element"></param>
        string Remove();

    }
}