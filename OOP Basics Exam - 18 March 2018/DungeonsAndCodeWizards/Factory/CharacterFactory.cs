using DungeonsAndCodeWizards.Model.Characters;
using DungeonsAndCodeWizards.Model.Enums;
using System;

namespace DungeonsAndCodeWizards.Factory
{
    public class CharacterFactory
    {
        public Character CreateCharacter(string faction, string type, string name)
        {
            Faction fact;
            if (faction.ToLower() == "csharp") fact = Faction.CSharp;
            else if (faction.ToLower() == "java") fact = Faction.Java;
            else throw new ArgumentException($"Invalid faction \"{faction}\"!");
            switch (type.ToLower())
            {
                case "warrior": return new Warrior(name, fact);
                case "cleric": return new Cleric(name, fact);
                default: throw new ArgumentException($"Invalid character type \"{type}\"!");
            }
        }
    }
}