using DungeonsAndCodeWizards.Model.Characters;
using System;

namespace DungeonsAndCodeWizards.Model.Items
{
    public abstract class Item
    {
        
        public int Weight { get; set; }
        protected Item(int weight)
        {
            Weight = weight;
        }
        public virtual void AffectCharacter(Character character)
        {
            if (!character.IsAlive) throw Character.affectDeadCharacterError;
        }
    }
}