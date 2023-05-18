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
            /*
             * Criteria:
             * - First character can't be a symbol or number
             * - Must contain '@'
             * - Must end in '.com'
             */
            const char atSymbol = '@';
            const string dotCom = ".com";

            if (email == null || email.Length == 0)
            {
                Console.WriteLine("Empty email provided");
                return;
            }

            if (char.IsNumber(email[0]) || char.IsSymbol(email[0]))
            {
                Console.WriteLine("Email cannot start with a symbol or number");
                return;
            }

            if (!email.Contains(atSymbol))
            {
                Console.WriteLine("Email is missing '@'");
                return;
            }

            if (!email.EndsWith(dotCom))
            {
                Console.WriteLine("Email must end in '.com'");
                return;
            }

            Console.WriteLine($"{email} is a valid email");
        }
    }
}
