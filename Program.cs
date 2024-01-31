using System;

namespace PremierLeagueTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teams = new string[] {
                "Tottenham", "Manchester City", "Manchester United", "Arsenal;", "Liverpool",
                "Chelsea"
            };
            
        
            string commandTeam = "Your randomly generated Premier League team is: {0}";
          
            int randomIndex;
            
            Random random = new Random();

            randomIndex = random.Next(teams.Length);
                    
            string randomTeam = teams[randomIndex];

            while (true)
            {;
                Console.Write("Enter a command (type 'help' for options): ");
                string command = Console.ReadLine().ToLower();

                if (command.ToLower() == "team")
                {
                
                    Console.WriteLine(commandTeam, randomTeam);
                    commandTeam = "you cant generate another team" + System.Environment.NewLine;
                }
                else if (command.ToLower() == "help")
                {
                    Console.WriteLine("Available commands:");
                    Console.WriteLine("- team: Generates a random Premier League team.");
                    Console.WriteLine("- quit: Exits the game.");
                    
                }
                else if (command.ToLower() == "quit")
                {
                    break;
                }
                else if (command.ToLower() == "teaminfo")
                {
                   Console.WriteLine(randomTeam);
                }
                else
                {
                    Console.WriteLine("Invalid command. Type 'help' for options.");
                }
            }
        }
    }
}

