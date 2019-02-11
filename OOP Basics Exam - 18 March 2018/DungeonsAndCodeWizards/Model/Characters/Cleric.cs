namespace DungeonsAndCodeWizards.Model.Characters
{
    using Contracts;
    using Model.Bags;
    using Model.Enums;
    using System;

    public class Cleric : Character, IHealable
    {
        InvalidOperationException enemyFractionHealError =new InvalidOperationException("Cannot heal enemy character!");
        public Cleric(string name, Faction faction) : base(name, 50, 25, 40, new Backpack(), faction)
        {
            RestHealMultiplier = 0.5;
        }

        public void Heal(Character target)
        {
            if (!IsAlive || !target.IsAlive) throw Character.affectDeadCharacterError;
            if (this.Faction != target.Faction) throw enemyFractionHealError;
            target.Health += this.AbilityPoints;
        }
    }
}