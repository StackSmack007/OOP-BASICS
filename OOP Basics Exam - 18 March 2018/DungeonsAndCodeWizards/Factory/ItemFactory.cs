using DungeonsAndCodeWizards.Model.Items;
using System;

namespace DungeonsAndCodeWizards.Factory
{
    public class ItemFactory
    {
        public Item CreateItem(string type)
        {
            switch (type.ToLower())
            {
                case "healthpotion": return new HealthPotion();
                case "poisonpotion": return new PoisonPotion();
                case "armorrepairkit": return new ArmorRepairKit();
            }
            throw new ArgumentException($"Invalid item type \"{type}\"!");
        }
    }
}