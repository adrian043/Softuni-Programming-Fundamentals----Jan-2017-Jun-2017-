using System;
using System.Collections.Generic;
using System.Linq;

namespace CottageScraper
{
    class CottageScraper
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var treesData = new Dictionary<string, List<decimal>>();

            while (inputLine != "chop chop")
            {
                var tokens = inputLine.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                var type = tokens[0];
                var height = decimal.Parse(tokens[1]);
                
                if (!treesData.ContainsKey(type))
                {
                    treesData[type] = new List<decimal>();
                }

                treesData[type].Add(height);
                                               
                inputLine = Console.ReadLine();
            }

            var treeType = Console.ReadLine();
            var minLengthPerTree = decimal.Parse(Console.ReadLine());

            decimal totalLength = treesData.Values.Sum(x => x.Sum());

            decimal pricePerMeter = totalLength / treesData.Values.Sum(x => x.Count);

            var usedLogsDict = treesData
                .Where(x => x.Key == treeType)
                .SelectMany(x => x.Value.Where(y => y >= minLengthPerTree)
                .ToList());
            
            var usedLogsPrice = usedLogsDict.Sum() * Math.Round(pricePerMeter, 2);
            var unusedLogs = Math.Round(treesData.Sum(x => x.Value.Sum()) - usedLogsDict.Sum(), 2);
            var unusedLogsPrice = Math.Round(pricePerMeter, 2) * unusedLogs * 0.25m;
            var cottageScraperSubTotal = Math.Round(usedLogsPrice + unusedLogsPrice, 2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
            Console.WriteLine($"Used logs price: ${usedLogsPrice:f2}");
            Console.WriteLine($"Unused logs price: ${unusedLogsPrice:f2}");
            Console.WriteLine($"CottageScraper subtotal: ${cottageScraperSubTotal:f2}");
        }
    }
}