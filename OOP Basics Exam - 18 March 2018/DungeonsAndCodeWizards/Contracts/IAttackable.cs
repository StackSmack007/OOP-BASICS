namespace DungeonsAndCodeWizards.Contracts
{
    using Model.Characters;
    public  interface IAttackable
    {
        void Attack(Character character);
    }
}