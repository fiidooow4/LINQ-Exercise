using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> videoGames = new List<string>
        {
            "Grand Theft Auto VI",
            "FIFA 23",
            "Super Mario Bros",
            "FIFA EA Sports 2024",
            "Grand Theft Auto v",
            "Call of Duty",
            "Fortnite",
            "NBA 2k24"
        };

        // Order the list of games by the length of the game name
        var orderedGames = videoGames.OrderBy(game => game.Length).ToList();

        // Print the ordered list
        Console.WriteLine("Ordered List of Video Games:");
        foreach (var game in orderedGames)
        {
            Console.WriteLine(game);
        }
    }
}
