using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

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
            var models = GetModels(typeof(Car));
            foreach (var model in models)
            {
                Console.WriteLine(model.Name);
            }

            Console.ReadKey();
        }

        // MARK: Write your solution here...
        // 1
        public static List<Type> GetModels(Type abstractClass)
        {
            // 2
            var allTypes = Assembly.GetAssembly(abstractClass).GetTypes();

            // 3
            var filteredTypes = allTypes.Where(type =>
                                                    !type.IsAbstract &&
                                                    abstractClass.IsAssignableFrom(type));

            // 4
            return filteredTypes.ToList();
        }
    }
}