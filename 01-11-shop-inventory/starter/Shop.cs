using System;
using System.Collections.Generic;
using System.Linq;

namespace shopinventory
{
    public class Shop
    {
        private Dictionary<int, string> inventory = new Dictionary<int, string>();

        // MARK: Write your solution here
        public string this[int i]
        {
            get
            {
                if (inventory.TryGetValue(i, out string name))
                {
                    return name;
                }

                throw new IndexOutOfRangeException($"No item at index {i}");
            }

            set
            {
                // Reference implementation just checked if index was already present
                // But I've changed it to ensure that no duplicate items are added
                if (inventory.Any(kvp => kvp.Value == value && kvp.Key != i))
                {
                    throw new ArgumentException($"Duplicate inventory item");
                }

                inventory[i] = value;
            }
        }
    }
}