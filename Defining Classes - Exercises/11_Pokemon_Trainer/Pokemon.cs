namespace _11_Pokemon_Trainer
{
    public class Pokemon
    {
        public Pokemon(string name,string element,int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }
        private string name;
        private string element;
        private int health;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Element
        {
            get { return this.element; }
            set { this.element = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
    }
}