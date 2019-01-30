namespace _03_Ferrari
{
    public abstract class Car:INterface
    {
        public string Model { get; private set; }
        public string Driver { get;protected set; }
        public Car(string model,string driver)
        {
            Model = model;
            Driver = driver;
        }
        public abstract string PushTheGasPedal();
        public abstract string UseBrakes();
    }
}