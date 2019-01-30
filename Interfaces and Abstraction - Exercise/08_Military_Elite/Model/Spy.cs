using Military.Contracts;
namespace Military.Model
{
    public class Spy : Soldier, ISpy
    {
        int codeNumber;
        public Spy(string firstName, string lastName, string id,int code):base(firstName,lastName,id)
        {
            CodeNumber = code;
        }

        public int CodeNumber
        {
            get
            {
                return codeNumber;
            }
            private set
            {
                codeNumber = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id}\nCode Number: {CodeNumber}\n";
        }
    }
}