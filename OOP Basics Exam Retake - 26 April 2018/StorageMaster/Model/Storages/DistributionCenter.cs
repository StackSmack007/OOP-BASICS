using StorageMaster.Model.Vehicles;

namespace StorageMaster.Model.Storages
{
    public class DistributionCenter:Storage
    {

        private const int CAPPACITYCONST = 2;
        private const int GARAGESLOTS = 5;

        private static Vehicle[] VEH = { new Van(), new Van(), new Van() };

        public DistributionCenter(string name) : base(name, CAPPACITYCONST, GARAGESLOTS, VEH) { }
    }
}