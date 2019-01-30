using BorderControl.Contracts;

namespace BorderControl.Model
{
   public class Robot : IDPosses
    {
        private string name;
        public string Id { get; private set; }
        public Robot(string name,string id)
        {
            this.name = name;
            this.Id = id;
        }
    }
}