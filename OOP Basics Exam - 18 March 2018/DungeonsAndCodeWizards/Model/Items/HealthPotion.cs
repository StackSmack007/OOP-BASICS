using DungeonsAndCodeWizards.Model.Characters;

namespace DungeonsAndCodeWizards.Model.Items
{
    public class HealthPotion : Item
    {
        public HealthPotion() : base(weight: 5) { }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.Health += 20;
        }
    }
}
