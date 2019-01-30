using BorderControl.Contracts;
using BorderControl.Model;
using System;
using System.Linq;

namespace BorderControl.Factory
{
    class ResidentFactory
    {
        public IDPosses GetResident(string input)
        {
            string[] inputArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string name = inputArgs[0];
            string id = inputArgs.Last();

            if (inputArgs.Length==2)
            {
                return new Robbot(name, id);
            }
            else
            {
                int age = int.Parse(inputArgs[1]);
                return new Human(name,age,id);
            }
        }
    }
}