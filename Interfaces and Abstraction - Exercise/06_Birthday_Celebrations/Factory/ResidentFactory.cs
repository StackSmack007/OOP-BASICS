using BorderControl.Model;
using System;

namespace BorderControl.Factory
{
    class ResidentFactory
    {
        public object GetResident(string input)
        {
            string[] inputArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string type = inputArgs[0];
            string name = inputArgs[1];

            if (type.ToLower() == "citizen")
            {
                int age = int.Parse(inputArgs[2]);
                string id = inputArgs[3];
                string birthDate = inputArgs[4];
                return new Human(name, age, id, birthDate);
            }
            else if (type.ToLower() == "robot")
            {
                string id = inputArgs[2];
                return new Robot(name, id);
            }
            else if (type.ToLower() == "pet")
            {
                string birthDate = inputArgs[2];
                return new Pet(name, birthDate);
            }
            return null;
        }
    }
}