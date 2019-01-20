using System;
using System.Collections.Generic;
using System.Linq;

namespace BankAccount
{
    public class StartUp
    {
        static void Main()
        {
            List<BankAccount> accounts = new List<BankAccount>();
            string[] input;
            while ((input = Console.ReadLine().Split())[0] != "End")
            {
                int id = int.Parse(input[1]);
                string command = input[0].ToLower();
                BankAccount currentAcc = accounts.FirstOrDefault(x => x.Id == id);
                if (currentAcc is null && command != "create")
                {
                    Console.WriteLine("Account does not exist");
                    continue;
                }
                switch (input[0].ToLower())
                {
                    case "create":
                        if (currentAcc is null)
                        {
                            accounts.Add(new BankAccount(id));
                            break;
                        }
                        Console.WriteLine("Account already exist");
                        break;
                    case "deposit":
                        currentAcc.Deposit(decimal.Parse(input[2]));
                        break;
                    case "withdraw":
                        currentAcc.Withdraw(decimal.Parse(input[2]));
                        break;
                    case "print":
                        Console.WriteLine(currentAcc);
                        break;
                }
            }
        }
    }
}