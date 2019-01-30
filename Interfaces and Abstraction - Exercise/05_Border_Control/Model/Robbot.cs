using BorderControl.Contracts;

namespace BorderControl.Model
{
   public class Robbot : IDPosses
    {
        private string name;
        public string Id { get; private set; }
        public Robbot(string name,string id)
        {
            this.name = name;
            this.Id = id;
        }
    }
}