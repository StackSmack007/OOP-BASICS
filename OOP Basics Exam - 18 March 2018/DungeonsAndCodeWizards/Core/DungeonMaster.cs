using DungeonsAndCodeWizards.Contracts;
using DungeonsAndCodeWizards.Factory;
using DungeonsAndCodeWizards.Model.Characters;
using DungeonsAndCodeWizards.Model.Enums;
using DungeonsAndCodeWizards.Model.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards.Core
{
    public class DungeonMaster
    {
      //  private readonly Func<string, ArgumentException> wrongFactionError = x => new ArgumentException($"Invalid faction \"{x}\"!");
      //  private readonly Func<string, ArgumentException> wrongCharacterTypeError = x => new ArgumentException($"Invalid character type \"{x}\"!");
      //  private readonly Func<string, ArgumentException> wrongItemTypeError = x => new ArgumentException($"Invalid item \"{x}\"!");
        private readonly Func<string, ArgumentException> characterNotFoundError = x => new ArgumentException($"Character {x} not found!");
        private readonly InvalidOperationException noItemsInPoolError = new InvalidOperationException("No items left in pool!");
        private readonly Func<string, ArgumentException> unableToAttackError = x => new ArgumentException($"{x} cannot attack!");
        private readonly Func<string, ArgumentException> unableToHealError = x => new ArgumentException($"{x} cannot heal!");

        private ItemFactory itemFactory;
        private CharacterFactory characterFactory;
        private List<Character> characterParty;
        private Stack<Item> itemPool;
        private int consecutiveRounds = 0;

        public DungeonMaster()
        {
            characterParty = new List<Character>();
            itemPool = new Stack<Item>();
            itemFactory = new ItemFactory();
            characterFactory = new CharacterFactory();
        }

        private Character GetCharacter(string name)
        {
            Character character = characterParty.FirstOrDefault(x => x.Name == name);
            if (character is null) throw characterNotFoundError(name);
            return character;
        }

        public string JoinParty(string[] args)
        {
            string faction = args[0];
            string characterType = args[1];
            string name = args[2];
            characterParty.Add(characterFactory.CreateCharacter(faction, characterType, name));
            return $"{name} joined the party!";
        }

        public string AddItemToPool(string[] args)
        {
            string itemName = args[0];
            itemPool.Push(itemFactory.CreateItem(itemName));
            return $"{itemName} added to pool.";
        }

        public string PickUpItem(string[] args)
        {
            string characterName = args[0];
            Character currentChar = GetCharacter(characterName);
            if (itemPool.Count == 0) throw noItemsInPoolError;
            currentChar.ReceiveItem(itemPool.Peek());
            return $"{characterName} picked up {itemPool.Pop().GetType().Name}!";
        }

        public string UseItem(string[] args)
        {
            string characterName = args[0];
            Character currentChar = GetCharacter(characterName);
            string itemName = args[1];
            Item item = currentChar.Bag.GetItem(itemName);
            currentChar.UseItem(item);
            return $"{characterName} used {itemName}.";
        }

        public string UseItemOn(string[] args)
        {
            string giverName = args[0];
            Character giverChar = GetCharacter(giverName);
            string receiverName = args[1];
            Character receiverChar = GetCharacter(receiverName);
            string itemName = args[2];
            Item item = giverChar.Bag.GetItem(itemName);
            giverChar.UseItemOn(item, receiverChar);
            return $"{giverName} used {itemName} on {receiverName}.";
        }

        public string GiveCharacterItem(string[] args)
        {
            string giverName = args[0];
            Character giverChar = GetCharacter(giverName);
            string receiverName = args[1];
            Character receiverChar = GetCharacter(receiverName);
            string itemName = args[2];
            Item item = giverChar.Bag.GetItem(itemName);
            giverChar.GiveCharacterItem(item, receiverChar);
            return $"{giverName} gave {receiverName} {itemName}.";
        }

        public string GetStats()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Character player in characterParty.OrderByDescending(x => x.IsAlive).ThenByDescending(x => x.Health))
            {
                sb.AppendLine($"{player.Name} - HP: {player.Health}/{player.BaseHealth}, AP: {player.Armor}/{player.BaseArmor}, Status: {(player.IsAlive ? "Alive" : "Dead")}");
            }
            return sb.ToString().TrimEnd();
        }

        public string Attack(string[] args)
        {
            string attackerName = args[0];
            Character attackerChar = GetCharacter(attackerName);
            string targetName = args[1];
            Character targetChar = GetCharacter(targetName);
            if (attackerChar is IAttackable attacker)
            {
                attacker.Attack(targetChar);
                StringBuilder sb = new StringBuilder();
                sb.Append($"{attackerName} attacks {targetName} for {attackerChar.AbilityPoints} hit points! ");
                sb.Append($"{targetName} has {targetChar.Health}/{targetChar.BaseHealth} HP and {targetChar.Armor}/{targetChar.BaseArmor} AP left!\n");
                if (!targetChar.IsAlive) sb.AppendLine($"{targetName} is dead!");
                return sb.ToString().TrimEnd();
            }
            throw unableToAttackError(attackerName);
        }

        public string Heal(string[] args)
        {
            string healerName = args[0];
            Character healerChar = GetCharacter(healerName);
            string targetName = args[1];
            Character targetChar = GetCharacter(targetName);
            if (healerChar is IHealable healer)
            {
                healer.Heal(targetChar);
                return $"{healerName} heals {targetName} for {healerChar.AbilityPoints}! {targetName} has {targetChar.Health} health now!";
            }
            throw unableToHealError(healerName);
        }

        public string EndTurn(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int aliveCounter = 0;
            foreach (Character character in characterParty.Where(x => x.IsAlive))
            {
                aliveCounter++;
                double healthBefore = character.Health;
                character.Rest();
                sb.AppendLine($"{character.Name} rests ({healthBefore} => {character.Health})");
            }
            if (aliveCounter <= 1)
            {
                consecutiveRounds++;
            }
            return sb.ToString().TrimEnd();
        }

        public bool IsGameOver()
        {
            if (consecutiveRounds > 1 || characterParty.Count == 0) return true;
            return false;
        }
    }
}