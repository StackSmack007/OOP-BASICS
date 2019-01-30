namespace BorderControl.Model
{
    public abstract class DataOfHuman
    {
        private string name;
        public string Id { get; private set; }
        public DataOfHuman(string name,string id)
        {
            this.name = name;
            this.Id = id;
        }
        public string Name { get => name;}
    }
}