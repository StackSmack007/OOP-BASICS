using System;

namespace _05_Pizza_Calories
{
   public class Program
    {
        static void Main()
        {
            string[] input;
            Pizza pizza=new Pizza();
            while ((input=Console.ReadLine().Split())[0]!="END")
            {
                string command = input[0];
                try
                {
                    switch (command.ToLower())
                    {
                        case "pizza":
                            pizza = new Pizza(input[1]);
                            break;
                        case "dough":
                            pizza.Dough = new Dough(input[1], input[2], int.Parse(input[3]));
                            break;
                        case "topping":
                            pizza.Toppings.Add(new Topping(input[1], int.Parse(input[2])));
                            if (pizza.Toppings.Count > 10)
                            {
                                throw new ArgumentException("Number of toppings should be in range [0..10].");
                            }
                            break;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    return;
                }
            }
            Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():F2} Calories.");
        }
    }
}