using System;

namespace _02ClassBoxDataValidation
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

       public double Length
        {
            set
            {
                if (value<=0)
                {
                    System.Console.WriteLine("Length cannot be zero or negative.");
                    Environment.Exit(0);
                }
                else
                {
                    this.length = value;
                }
            }
        }

       public double Width
        {
            set
            {
                if (value <= 0)
                {
                    System.Console.WriteLine("Width cannot be zero or negative.");
                    Environment.Exit(0);
                }
                else
                {
                    this.width = value;
                }
            }
        }

        public double Height
        {
            set
            {
                if (value <= 0)
                {
                    System.Console.WriteLine("Height cannot be zero or negative.");
                    Environment.Exit(0);
                }
                else
                {
                    this.height = value;
                }
            }
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