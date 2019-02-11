namespace DungeonsAndCodeWizards.Model.Characters
{
    using Contracts;
    using Model.Bags;
    using Model.Enums;
    using System;

    public class Warrior : Character, IAttackable
    {
        InvalidOperationException targetSelfError = new InvalidOperationException("Cannot attack self!");
        Func<string, ArgumentException> friendlyFireError = faction => new ArgumentException($"Friendly fire! Both characters are from {faction} faction!");

        public Warrior(string name, Faction faction) : base(name, 100, 50, 40, new Satchel(), faction) { }

        public void Attack(Character target)
        {
            if (!IsAlive || !target.IsAlive) throw Character.affectDeadCharacterError;
            if (this == target) throw targetSelfError;
            if (this.Faction == target.Faction) throw friendlyFireError(this.Faction.ToString());
            target.TakeDamage(this.AbilityPoints);
        }
    }
}