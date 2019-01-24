using System;

namespace _02ClassBoxDataValidation
{
    class Program
    {
        static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Box box = new Box(length, width, height);
            Console.WriteLine(box.GetTotalArea() + "\n" + box.GetLateralArea() + "\n" + box.GetVolume());
        }
    }
}
