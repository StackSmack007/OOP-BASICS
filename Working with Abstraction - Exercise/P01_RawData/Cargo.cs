namespace P01_RawData
{
    public class Cargo
    {
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;

        }
        public string Type { get; }
        public int Weight { get; }
    }
}
