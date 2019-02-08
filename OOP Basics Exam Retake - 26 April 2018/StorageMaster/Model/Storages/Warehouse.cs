using StorageMaster.Model.Vehicles;

namespace StorageMaster.Model.Storages
{
    public class Warehouse : Storage
    {
        private const int CAPPACITYCONST = 10;
        private const int GARAGESLOTS = 10;

        private static Vehicle[] VEH = { new Semi(),new Semi(),new Semi() };

        public Warehouse(string name) : base(name, CAPPACITYCONST, GARAGESLOTS, VEH) { }
    }
}