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
            
        
            string commandTeam = "Your randomly generated Premier League team is: {0}";
          
            int randomIndex;
            
            Random random = new Random();

            while (true)
            {;
                Console.Write("Enter a command (type 'help' for options): ");
                string command = Console.ReadLine().ToLower();

                if (command.ToLower() == "team")
                {
                    randomIndex = random.Next(teams.Length);
                    string randomTeam = teams[randomIndex];
                    Console.WriteLine(commandTeam, randomTeam);
                    commandTeam = "you cant generate another team" + System.Environment.NewLine;
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
