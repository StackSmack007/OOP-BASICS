namespace P01_RawData
{
    public class Engine
    {
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }
        public int Speed { get; }
        public int Power { get; }
    }
}
