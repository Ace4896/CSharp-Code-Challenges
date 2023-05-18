using System;
using System.Reflection;

namespace reflection
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Hit ENTER to find the vehicles you're looking for!");
            Console.ReadKey();

            // MARK: Result
            GetModels(typeof(Car));
            Console.ReadKey();
        }

        // MARK: Write your solution here...
        public static void GetModels(Type baseType)
        {
            // Goal is to find all concrete classes that inherit from this base type
            // This requires reflection, as we have to search the current assembly
            foreach (Type assemblyType in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (!assemblyType.IsAbstract && baseType.IsAssignableFrom(assemblyType))
                {
                    Console.WriteLine($"{assemblyType.Name} is derived from {baseType.Name}");
                }
            }
        }
    }
}