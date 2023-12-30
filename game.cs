using System;

namespace PremierLeagueTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teams = new string[] {
                "Arsenal", "Aston Villa", "Bournemouth", "Brentford", "Brighton & Hove Albion",
                "Chelsea", "Crystal Palace", "Everton", "Fulham", "Liverpool", 
                "Manchester City", "Manchester United", "Newcastle United", "Nottingham Forest",
                "Sheffield United", "Tottenham Hotspur", "West Ham United", "Wolverhampton Wanderers"
            };

            Random random = new Random();

            while (true)
            {
                Console.Write("Enter a command (type 'help' for options): ");
                string command = Console.ReadLine().ToLower();

                if (command == "team")
                {
                    int randomIndex = random.Next(teams.Length);
                    string randomTeam = teams[randomIndex];
                    Console.WriteLine("Your randomly generated Premier League team is: {0}", randomTeam);
                }
                else if (command == "help")
                {
                    Console.WriteLine("Available commands:");
                    Console.WriteLine("- team: Generates a random Premier League team.");
                    Console.WriteLine("- quit: Exits the game.");
                }
                else if (command == "quit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid command. Type 'help' for options.");
                }
            }
        }
    }
}
