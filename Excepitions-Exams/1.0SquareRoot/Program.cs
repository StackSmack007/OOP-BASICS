using System;

namespace _1._0SquareRoot
{
    class Program
    {
        static void Main()
        {

            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("The reusult is {0:F2}", SquareRoot(number));
            }
            catch (ArgumentNullException exnull)
            {
                Console.WriteLine("e napishi neshto de...");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                //  Console.WriteLine(ex.InnerException.Message);
                //  throw ex;
            }
            catch (FormatException e)
            {
                Console.WriteLine("ne parsvam dobre");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("polzvai big int po angelite!");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
        static double SquareRoot(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Invalid number");
            }
            return Math.Sqrt((double)n);
        }

    }
}