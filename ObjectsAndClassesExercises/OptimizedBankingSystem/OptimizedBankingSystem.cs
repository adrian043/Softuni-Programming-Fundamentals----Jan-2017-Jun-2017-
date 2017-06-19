using System;
using System.Collections.Generic;
using System.Linq;

namespace OptimizedBankingSystem
{
    class BankAccout
    {
        public string Name { get; set; }

        public string Bank { get; set; }

        public decimal Balance { get; set; }
    }
    class OptimizedBankingSystem
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var data = new List<BankAccout>();

            while (inputLine != "end")
            {
                var tokens = inputLine.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

                var newBankAcc = new BankAccout
                {
                    Name = tokens[1],
                    Bank = tokens[0],
                    Balance = decimal.Parse(tokens[2])
                };

                data.Add(newBankAcc);

                inputLine = Console.ReadLine();
            }

            var result = data
                .OrderByDescending(x => x.Balance)
                .ThenBy(x => x.Bank.Length);

            foreach (var item in result)
            {                
                Console.WriteLine($"{item.Name} -> {item.Balance} ({item.Bank})");
            }
        }
    }
}