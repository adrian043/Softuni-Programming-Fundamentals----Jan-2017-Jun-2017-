using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderedBankingSystem
{
    class OrderedBankingSystem
    {
        public static void Main()
        {
            var accountData = new Dictionary<string, Dictionary<string, decimal>>();
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var token = inputLine.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var bank = token[0];
                var owner = token[1];
                var amount = decimal.Parse(token[2]);

                if (!accountData.ContainsKey(bank))
                {
                    accountData[bank] = new Dictionary<string, decimal>();
                }               

                if (!accountData[bank].ContainsKey(owner))
                {
                    accountData[bank][owner] = amount;
                }

                accountData[bank][owner] += amount;

                inputLine = Console.ReadLine();
            }

            foreach (var item in accountData.Keys)
            {
                Console.Write($"{item}: ");
                var ownerAmountPair = accountData[item];
                foreach (var owp in ownerAmountPair)
                {
                    Console.WriteLine($"{owp.Key} {owp.Value}");
                }
            }
        }
    }
}