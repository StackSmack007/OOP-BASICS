namespace _07_Speed_Racing
{
    public class Car
    {
        public Car(string model, double fuelAmaunt, double fuelConsumption)
        {
            this.model = model;
            this.fuelAmaunt = fuelAmaunt;
            this.fuelConsumption = fuelConsumption;
            this.travelledDistance = 0.0;
        }
        private string model;
        private double fuelAmaunt;
        private double fuelConsumption;
        private double travelledDistance;

        public string Model
        {
            get { return model; }
        }
        public double FuelAmaunt
        {
            get { return fuelAmaunt; }
         }
        public double FuelConsumption
        {
            get { return fuelAmaunt; }
        }
        public double DistTraveled
        {
            get { return travelledDistance; }
        }
        public void PassDistance(double distance)
        {
            double fuelRequired = distance * fuelConsumption;
            if (fuelRequired <= fuelAmaunt)
            {
                travelledDistance += distance;
                fuelAmaunt -= fuelRequired;
            }
            else
            {
                System.Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
