namespace DungeonsAndCodeWizards.Contracts
{
    using Model.Characters;
    public interface IHealable
    {
        void Heal(Character character);
    }
}