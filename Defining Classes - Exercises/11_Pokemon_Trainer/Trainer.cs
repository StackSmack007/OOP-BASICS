using System.Collections.Generic;

namespace _11_Pokemon_Trainer
{
    public class Trainer
    {
        private string name;
        private int badges;
        List<Pokemon> pokemons;
        public Trainer(string name)
        {
            this.Name = name;
            this.Badges = 0;
            this.Pokemons = new List<Pokemon>();
        }
       public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }
        public int Badges
        {
            get { return badges; }
            set { badges = value; }
        }
       public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}