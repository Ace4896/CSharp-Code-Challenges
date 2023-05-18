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

            Console.ReadKey();
        }

        // MARK: Calculation
        public static string[] BreakdownURL(string urlString)
        {
            /*
             * Criteria:
             * - Remove 'www.' at the beginning
             * - Replace dashes with empty space
             * - Split the URL at each '/'
             */

            // Only want to remove 'www.' at the beginning, so used substring here
            const string www = "www.";
            string trimmedUrl = urlString.StartsWith(www) ? urlString.Substring(www.Length) : urlString;
            return trimmedUrl.Replace('-', ' ').Split('/');
        }
    }
}
