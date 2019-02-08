namespace StorageMaster.Model.Products
{
    public class HardDrive : Product
    {
        private const double WEIGHTCONST = 1;

        public HardDrive(double price) : base(price, WEIGHTCONST) { }
    }
}