using System;

namespace decomposingurls
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            string exampleURL = "www.docs.microsoft.com/dotnet/csharp/whats-new/csharp-version-history";
            Console.WriteLine($"Hit ENTER to break down the URL into its component parts: {exampleURL}");
            Console.ReadKey();

            // MARK: Result
            var components = BreakdownURL(exampleURL);
            for (int i = 0; i < components.Length; i++)
            {
                var indent = new string(' ', i * 2);
                Console.WriteLine($"{indent} -> {components[i]}");
            }
        }

        // MARK: Calculation
        public static string[] BreakdownURL(string urlString)
        {
            // 1
            string noWWW = urlString.Remove(0, 4);

            // 2
            string noDashes = noWWW.Replace("-", " ");

            // 3
            string[] components = noDashes.Split('/');

            // Alternative
            //string[] components2 = urlString.Remove(0, 4).Replace("-", " ").Split('/');

            return components;
        }
    }
}