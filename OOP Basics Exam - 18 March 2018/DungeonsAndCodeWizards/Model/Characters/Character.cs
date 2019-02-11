namespace DungeonsAndCodeWizards.Model.Characters
{
    using Model.Bags;
    using Model.Enums;
    using Model.Items;
    using System;

    public abstract class Character
    {
        public static readonly InvalidOperationException affectDeadCharacterError = new InvalidOperationException("Must be alive to perform this action!");
        private readonly ArgumentException emptyName = new ArgumentException("Name cannot be null or whitespace!");

        private string name;
        private double health;//current health between 0 and BaseHealth
        private double armor;

        public string Name
        {
            get => name;
            protected set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) throw emptyName;
                name = value;
            }
        }

        public double BaseHealth { get; protected set; }

        public double Health
        {
            get { return this.health; }
            set
            {
                if (value <= 0)
                {
                    health = 0;
                    IsAlive = false;
                }
                else if (value > BaseHealth)
                {
                    health = BaseHealth;
                }
                else
                {
                    this.health = value;
                }
            }
        }

        public double BaseArmor { get; protected set; }

        public double Armor
        {
            get { return this.armor; }
            set
            {
                if (value < 0) armor = 0;
                else if (value > BaseArmor) armor = BaseArmor;
                else this.armor = value;
            }
        }

        public double AbilityPoints { get; protected set; }

        public Bag Bag { get; protected set; }//?modifiers??

        public Faction Faction { get; set; }


        public bool IsAlive { get; set; }

        public double RestHealMultiplier { get; protected set; }

        public Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
        {
            RestHealMultiplier = 0.2;
            Name = name;
            BaseHealth = health;
            Health = health;
            BaseArmor = armor;
            Armor = armor;
            AbilityPoints = abilityPoints;
            Bag = bag;
            Faction = faction;
            IsAlive = true;
        }

        public void TakeDamage(double hitPoints)
        {
            if (!IsAlive) throw affectDeadCharacterError;
            double damage = hitPoints - Armor;//possitive if damage is greater than armor else negative
            Armor -= hitPoints;
            if (damage > 0) Health -= damage;
        }

        public void Rest()
        {
            if (!IsAlive) throw affectDeadCharacterError;
            Health += BaseHealth * RestHealMultiplier;
        }

        public void UseItem(Item item)
        {
            UseItemOn(item, this);
        }

        public void UseItemOn(Item item, Character target)//???????????BagCheck?
        {
            if (!IsAlive) throw affectDeadCharacterError;
            item.AffectCharacter(target);
        }

        public void GiveCharacterItem(Item item, Character target)
        {
            if (!IsAlive) throw affectDeadCharacterError;
            target.ReceiveItem(item);
        }

        public void ReceiveItem(Item item)
        {
            if (!IsAlive) throw affectDeadCharacterError;
            Bag.AddItem(item);
        }
    }
}