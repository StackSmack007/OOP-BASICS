using StorageMaster.Model.Vehicles;

namespace StorageMaster.Model.Storages
{
    public class AutomatedWarehouse : Storage
    {
        private const int CAPPACITYCONST = 1;
        private const int GARAGESLOTS = 2;
        private static Vehicle[] VEH = { new Truck() };

        public AutomatedWarehouse(string name) : base(name, CAPPACITYCONST, GARAGESLOTS, VEH) { }
    }
}
