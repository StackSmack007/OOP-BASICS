using System;

namespace FixingVol2
{
    public class Program
    {
        static void Main()
        {
            int num1, num2;
            byte? result=null;

            num1 = 11;
            num2 = 600;
            try
            {
                result = Convert.ToByte(num1 + num2);
              
            }
            catch (OverflowException ov) 
            when (num1==10)
            {
                Console.WriteLine("Too large number/s But num1=10 atleast!");
            }
            catch (OverflowException ov)
            {
                Console.WriteLine("Too large number/s!");
            }
            finally
            {
  Console.WriteLine($"{num1} + {num2} = {result}");
            }
        }
    }
}