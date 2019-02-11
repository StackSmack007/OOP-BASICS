using DungeonsAndCodeWizards.Model.Items;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DungeonsAndCodeWizards.Model.Bags
{
    public abstract class Bag
    {
        private InvalidOperationException bagFullError = new InvalidOperationException("Bag is full!");
        private InvalidOperationException emptyBagError = new InvalidOperationException("Bag is empty!");
        private Func<string, ArgumentException> itemNotFoundError = x => new ArgumentException($"No item with name {x} in bag!");


        private readonly List<Item> items;//it allows via methods to insert values!

        public int Capacity { get; private set; }
        public int Load { get { return items.Sum(x => x.Weight); } }

        public IReadOnlyCollection<Item> Items { get { return items.AsReadOnly(); } }

        public Bag(int capacity)
        {
            Capacity = capacity;
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            if (Load + item.Weight > Capacity)
            {
                throw bagFullError;
            }
            items.Add(item);
        }
        public Item GetItem(string name)
        {
            if (Items.Count == 0) throw emptyBagError;
            var item = Items.FirstOrDefault(x => x.GetType().Name.ToLower() == name.ToLower());
            if (item is null) throw itemNotFoundError(name);
            items.Remove(item);
            return item;
        }
    }
}