using System;
using System.Collections.Generic;

namespace UserLogins
{
    class UserLogins
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, string>();
            int logginsFailed = 0;
            bool loginStarted = false;

            while (input != "end")
            {                
                var tokens = input.Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var username = tokens[0];
                string password;

                if (tokens.Length == 1)
                {
                    password = null;
                }
                else
                {
                    password = tokens[1];
                }
                               
                if (input == "login")
                {
                    loginStarted = true;
                }

                if (!result.ContainsKey(username) && loginStarted == false)
                {
                    result[username] = password;
                }
                else if (result.ContainsKey(username) && loginStarted == false)
                {
                    result[username] = password;
                }
                else if (loginStarted == true && ((result.ContainsKey(username) && !result.ContainsValue(password)) || (!result.ContainsKey(username) && result.ContainsValue(password))))
                {
                    Console.WriteLine($"{username}: login failed");
                    logginsFailed++;
                }
                else if (input != "login")
                {
                    Console.WriteLine($"{username}: logged in successfully");
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"unsuccessful login attempts: {logginsFailed}");
        }
    }
}