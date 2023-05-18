using System;

namespace validatingemails
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter the email address you'd like to validate:");
            var input = Console.ReadLine();

            // MARK: Result
            ValidateEmail(input);
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static void ValidateEmail(string email)
        {
            // 1
            char first = email[0];
            string atSymbol = "@";
            string dotCom = ".com";

            // 2
            if (Char.IsNumber(first) || Char.IsSymbol(first))
            {
                Console.WriteLine("\nSorry, emails can't start with numbers or symbols...");
                return;
            }

            // 3
            if (!email.Contains(atSymbol))
            {
                Console.WriteLine("\nYou have to include an '@' character...");
                return;
            }

            // 4
            if (email.Substring(email.Length - 4) != dotCom)
            {
                Console.WriteLine("\nGotta have a '.com' at the end...");
                return;
            }

            // 5
            Console.WriteLine("\nEmail is valid!");
        }
    }
}