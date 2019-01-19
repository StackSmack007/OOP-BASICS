namespace _10_Car_Salesman
{
    public class Engine
    {
        private string model;
        private int power;
        private string displacement;
        private string efficiency;

        public Engine(string model,string power)
        {
            this.Model = model;
            this.Power = int.Parse(power);
            this.Displacement = "n/a";
            this.Efficiency = "n/a";
        }
        public Engine() { }
        public Engine(string model, string power,int displacement):this(model,power)
        {
            this.Displacement =displacement.ToString();
        }
        public Engine(string model, string power, string efficiency) : this(model, power)
        {
            this.Efficiency = efficiency;
        }
        public Engine(string model, string power, int displacement, string efficiency) : this(model, power)
        {
            this.Displacement = displacement.ToString();
            this.Efficiency = efficiency;
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        public string Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }
        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }
    }
}