using System;

namespace shopinventory
{
    class MainClass
    {
        // 1
        static Shop shop = new Shop();

        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Add your inventory items:");

            for(int index = 0; index < 3; index++)
            {
                var item = Console.ReadLine();
                AddItem(index, item);
            }

            // MARK: Result
            Console.WriteLine("Retrieve all stored items:");
            GetAllItems();
        }

        public static void AddItem(int index, string name)
        {
            // 2
            try
            {
                shop[index] = name;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void GetAllItems()
        {
            // 3
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.WriteLine(shop[i]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}