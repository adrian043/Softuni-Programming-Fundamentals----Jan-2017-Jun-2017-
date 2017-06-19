using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace RegisteredUsers
{
    class RegisteredUsers
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var pair = new Dictionary<string, DateTime>();
                
            while (inputLine != "end")
            {
                var tokens = inputLine.Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var username = tokens[0];
                var date = DateTime.ParseExact(tokens[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                
                pair[username] = date;

                inputLine = Console.ReadLine();
            }

            var orderedUsers = pair
                .Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var userDatePair in orderedUsers)
            {
                Console.WriteLine($"{userDatePair.Key}");
            }
        }
    }
}