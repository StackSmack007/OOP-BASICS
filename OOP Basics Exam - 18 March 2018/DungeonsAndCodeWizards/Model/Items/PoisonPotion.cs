using DungeonsAndCodeWizards.Model.Characters;

namespace DungeonsAndCodeWizards.Model.Items
{
    public class PoisonPotion : Item
    {
        public PoisonPotion() : base(weight: 5) { }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.Health -= 20;//automaticly sets IsAlive on False in the CharacterClass!
        }
    }
}