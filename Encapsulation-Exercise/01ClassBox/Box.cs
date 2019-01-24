namespace _01ClassBox
{
    public class Box
    {
        private double length;
        private double height;
        private double width;
        
        public Box(double length, double height, double width)
        {
            this.length = length;
             this.height = height;
            this.width = width;
           
        }

        public string GetTotalArea()
        {
            double areaTotal = (height * (length + width) + length * width) * 2;
            return $"Surface Area - {areaTotal:F2}";
        }

        public string GetLateralArea()
        {
            double areaLateral = height * (length + width) * 2;
            return $"Lateral Surface Area - {areaLateral:F2}";
        }

        public string GetVolume()
        {
            double volume = height * length * width;
            return $"Volume - {volume:F2}";
        }
    }
}