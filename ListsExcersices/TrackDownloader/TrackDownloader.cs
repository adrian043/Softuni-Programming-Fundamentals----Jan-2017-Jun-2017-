using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackDownloader
{
    class TrackDownloader
    {
        static void Main(string[] args)
        {
            var blackList = Console.ReadLine().Split(' ');
            var songsList = Console.ReadLine();
            var result = new List<string>();

            while (songsList != "end")
            {
                bool isOnBlacklist = false;
                foreach (var song in blackList)
                {
                    if (songsList.Contains(song))
                    {
                        isOnBlacklist = true;
                        break;
                    }
                }
                if (!isOnBlacklist)
                {
                    result.Add(songsList);
                }
                songsList = Console.ReadLine();
            }
            result.Sort();
            Console.WriteLine(string.Join("\n", result));
        }
    }
}
