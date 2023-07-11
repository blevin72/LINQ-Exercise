using System.Linq;
using System.Collections.Generic;
namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>() { "Starcraft", "Madden", "Halo", "Last of Us" };
            videoGames.Add("Call of Duty");
            videoGames.Add("God of War");

            videoGames.OrderBy(videoGames => videoGames.Length).ToList().ForEach(videoGames => Console.WriteLine(videoGames));
        }
    }
}
