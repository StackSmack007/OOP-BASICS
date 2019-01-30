using Military.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Military.Factories
{
   public class SoldierFactory
    {

        public Soldier GetSoldier(string[] input, List<Soldier> soldierPool)
        {
            string type = input[0];
            string id = input[1];
            string firstName = input[2];
            string lastName = input[3];
            decimal salary = type != "Spy" ? decimal.Parse(input[4]) : 0;
            int code = type == "Spy" ? int.Parse(input[4]) : 0;
            string corpus = type == "Engineer"||type=="Commando" ? input[5] : null;

            if (type == "Private") return new Private(firstName, lastName, id, salary);

            if (type == "Spy") return new Spy(firstName, lastName, id, code);

            if (type == "LieutenantGeneral")
            {
                List<Soldier> privates = new List<Soldier>();
                string[] privatesIds = input.Skip(4).ToArray();
                foreach (string idNumber in privatesIds)
                {
                    var privateFound = soldierPool.Where(x => x.GetType().Name == "Private").FirstOrDefault(x => x.Id == idNumber);
                    if (privateFound != null)
                    {
                        privates.Add(privateFound);
                    }
                }
                return new LiutenantGeneral(firstName, lastName, id, salary, privates);
            }

            try
            {//skipping if the corps are not correct!
                if (type == "Engineer")
                {
                    var repairsArr = input.Skip(6).ToArray();
                    List<Repair> repairs = new List<Repair>();
                    for (int i = 0; i < repairsArr.Length; i += 2)
                    {
                        string partName = repairsArr[i];
                        int repairHours = int.Parse(repairsArr[i + 1]);
                        repairs.Add(new Repair(partName, repairHours));
                    }
                    return new Engineer(firstName, lastName, id, salary, corpus, repairs);
                }
                else if (type == "Commando")
                {
                    var missionsArr = input.Skip(6).ToArray();
                    List<Mission> missions = new List<Mission>();
                    for (int i = 0; i < missionsArr.Length; i += 2)
                    {
                        string codeName = missionsArr[i];
                        string state = missionsArr[i + 1];
                        try
                        {
                            missions.Add(new Mission(codeName, state));
                        }
                        catch {}
                    }
                    return new Comando(firstName, lastName, id, salary, corpus, missions);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return null;
        }
    }
}