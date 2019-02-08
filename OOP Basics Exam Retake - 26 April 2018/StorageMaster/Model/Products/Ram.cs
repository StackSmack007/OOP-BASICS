namespace StorageMaster.Model.Products
{
    public class Ram : Product
    {
        private const double WEIGHTCONST = 0.1;

        public Ram(double price) : base(price, WEIGHTCONST) { }
    }
}