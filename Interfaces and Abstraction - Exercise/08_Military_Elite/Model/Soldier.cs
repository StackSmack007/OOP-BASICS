using Military.Contracts;
namespace Military.Model
{
    public abstract class Soldier : ISoldier
    {
        private string firstName;
        private string lastName;
        private string id;
        public Soldier(string firstName, string lastName, string id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }

        public virtual string FirstName { get { return firstName; } private set { firstName = value; } }

        public virtual string LastName { get { return lastName; } private set { lastName = value; } }

        public virtual string Id { get { return this.id; } private set { this.id = value; } }
    }
}