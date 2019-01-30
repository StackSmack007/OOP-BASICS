namespace _03_Ferrari
{
    public class Ferrari : Car
    {
        public Ferrari(string model, string driver) : base(model, driver) { }
        public override string PushTheGasPedal()
        {
            return "Zadu6avam sA!";
        }
        public override string UseBrakes()
        {
            return "Brakes!";
        }
    }
}