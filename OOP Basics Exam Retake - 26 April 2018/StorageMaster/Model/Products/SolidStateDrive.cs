namespace StorageMaster.Model.Products
{
    public  class SolidStateDrive:Product
    {
        private const double WEIGHTCONST = 0.2;

        public SolidStateDrive(double price) : base(price, WEIGHTCONST) { }
    }
}