using System;

namespace BettingGame
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random random = new Random();

            double odds = 0.75;

            Guy player = new Guy()
            {
                Name = "The player", Cash = 100
            };

            Console.WriteLine("Welcome to the ZomboCom Casino. The odds here are 0.75");

            while (player.Cash > 0)
            {
                player.WriteMyInfo();

                Console.Write("Please input how much you want to bet: ");
                string howMuch = Console.ReadLine();
                int.TryParse(howMuch, out int amount);

                if (amount > player.Cash)
                {
                    Console.WriteLine("Not enough CASH there stranger. The house is watching you...");
                }

                else
                {
                    int pot = amount * 2;

                    if (random.NextDouble() > odds)
                    {
                        Console.WriteLine("Huzzah, it's a win of " + "$" + pot + " for you!");
                        player.ReceiveCash(pot);
                    }
                    else
                    {
                        Console.WriteLine("You lose " + "$" + amount + "." + " Bad luck, friend.");
                        player.GiveCash(amount);
                    }
                }
  
            }

            Console.WriteLine("Game over. The house wins all.");
            string gameReset = Console.ReadLine();
            if (gameReset == "Restart")
            {
                Main(args);
            }

        }
    }
}
