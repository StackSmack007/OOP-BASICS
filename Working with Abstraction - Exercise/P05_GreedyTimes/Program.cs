using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{
    public class Potato
    {
        static void Main(string[] args)
        {
            long bagLimit = long.Parse(Console.ReadLine());
            string[] itemsArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var bag = new Dictionary<string, Dictionary<string, long>>();
            long gold = 0;
            long gems = 0;
            long cash = 0;

            for (int i = 0; i < itemsArr.Length; i += 2)
            {
                long amauntCollected = gold + gems + cash;
                string itemName = itemsArr[i];
                long amaunt = long.Parse(itemsArr[i + 1]);
                string type = Identify(itemName);
                if (type == "UFO" || amauntCollected + amaunt > bagLimit)
                {
                    continue;
                }
                if (!bag.ContainsKey(type))
                {
                    bag[type] = new Dictionary<string, long>();
                }

                switch (type)
                {
                    case "Gem":
                        if (gold >= gems + amaunt)
                        {
                            gems += amaunt;
                            if (bag["Gem"].ContainsKey(itemName))
                            {
                                bag["Gem"][itemName] += amaunt;
                            }
                            else
                            {
                                bag["Gem"][itemName] = amaunt;
                            }
                        }
                        break;
                    case "Cash":
                        if (gems >= cash + amaunt)
                        {
                            cash += amaunt;
                            if (bag["Cash"].ContainsKey(itemName))
                            {
                                bag["Cash"][itemName] += amaunt;
                            }
                            else
                            {
                                bag["Cash"][itemName] = amaunt;
                            }
                        }
                        break;
                    default:
                        gold += amaunt;
                        if (bag["Gold"].ContainsKey(itemName))
                        {
                            bag["Gold"][itemName] += amaunt;
                        }
                        else
                        {
                            bag["Gold"][itemName] = amaunt;
                        }
                        break;
                }
            }
            Print(bag);         
            }

        private static void Print(Dictionary<string, Dictionary<string, long>> bag)
        {   
            foreach (var kvp in bag.Where(x => x.Value.Sum(y => y.Value)>0).OrderByDescending(x=>x.Value.Sum(y=>y.Value)))
            {
                Console.WriteLine($"<{kvp.Key}> ${kvp.Value.Sum(y=>y.Value)}");
                foreach (var item in kvp.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item.Key} - {item.Value}");
                }
            }
        }

        public static string Identify(string itemName)
            {
                itemName = itemName.ToLower();
                string result = "UFO";
                if (itemName.Length == 3)
                {
                    result = "Cash";
                }
                else if (itemName.EndsWith("gem"))
                {
                    result = "Gem";
                }
                else if (itemName == "gold")
                {
                    result = "Gold";
                }
                return result;
            }
        }
    }