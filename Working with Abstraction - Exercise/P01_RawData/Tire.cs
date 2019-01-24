namespace P01_RawData
{
    public class Tire
    {
        public Tire(double pressure, int age)
        {
            Pressure = pressure;
            Age = age;
        }
        public double Pressure { get; }
        public int Age { get; }
    }
}
