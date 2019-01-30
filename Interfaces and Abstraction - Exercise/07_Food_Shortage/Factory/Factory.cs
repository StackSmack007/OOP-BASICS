using BorderControl.Contracts;
using BorderControl.Model;
using System;

namespace BorderControl.Factory
{
    class Factory
    {
        public IBuyer GetResident(string input)
        {
            string[] inputArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string name = inputArgs[0];
            int age = int.Parse(inputArgs[1]);

            if (inputArgs.Length == 3)
            {
                string group = inputArgs[2];
                return new Rebel(name, age, group);
            }
            else if (inputArgs.Length == 4)
            {
                string id = inputArgs[2];
                string birthDate = inputArgs[3];
                return new Citizen(name, age, id, birthDate);
            }
            return null;
        }
    }
}