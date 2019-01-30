using Military.Contracts;
namespace Military.Model
{
    public class Repair : IRepair
    {
        private string partName;
        private int hoursWorked;
        public Repair(string partName, int hoursWorked)
        {
            PartName = partName;
            HoursWorked = hoursWorked;
        }

        public string PartName
        {
            get
            {
                return partName;
            }
            private set
            {
                partName = value;
            }
        }

        public int HoursWorked
        {
            get
            {
                return hoursWorked;
            }
            private set
            {
                hoursWorked = value;
            }
        }

        public override string ToString()
        {
            return $"Part Name: {PartName} Hours Worked: {HoursWorked}";
        }
    }
}