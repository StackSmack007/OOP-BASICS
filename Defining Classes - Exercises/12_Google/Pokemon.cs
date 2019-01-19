namespace _12_Google
{
    public class Pokemon
    {
        private string name;
        private string type;

        public Pokemon(string[] input)
        {
            this.Name = input[2];
            this.Type = input[3];
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}