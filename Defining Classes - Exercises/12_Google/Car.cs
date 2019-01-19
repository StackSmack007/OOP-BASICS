namespace _12_Google
{
    public class Car
    {
        private string model;
        private int carSpeed;
        public Car(string[] input)
        {
            this.Model = input[2];
            this.CarSpeed = int.Parse(input[3]);
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int CarSpeed
        {
            get { return carSpeed; }
            set { carSpeed = value; }
        }
    }
}