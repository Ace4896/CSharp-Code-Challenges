using System;

namespace shopinventory
{
    class MainClass
    {
        private static Shop shop = new();

        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Add your inventory items:");

            for (int index = 0; index < 3; index++)
            {
                var item = Console.ReadLine();
                AddItem(index, item);
            }

            // MARK: Result
            Console.WriteLine("Retrieve all stored items:");
            GetAllItems();
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static void AddItem(int index, string name)
        {
            try
            {
                shop[index] = name;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // MARK: Write your solution here
        public static void GetAllItems()
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.WriteLine(shop[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}