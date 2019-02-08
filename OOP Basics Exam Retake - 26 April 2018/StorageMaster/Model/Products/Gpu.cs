namespace StorageMaster.Model.Products
{
    public class Gpu : Product
    {
        private const double WEIGHTCONST = 0.7;
        public Gpu(double price) : base(price, WEIGHTCONST) { }
    }
}