using System;

namespace BettingGame
{
    class Guy
    {
        public string Name;
        public int Cash;

        /// <summary>
        /// Writes name and amount of cash to the console.
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " has " + "$" + Cash + ".");
        }

        /// <summary>
        /// Gives some cash, removes from wallet (or prints message to console if insuffient funds).
        /// </summary>
        /// <param name="amount">Amount of cash to give.</param>
        /// <returns>Amount of cash removed from wallet. Otherwise, 0 if insufficient funds or invalid amount.</returns>
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + "$" + amount + " isn't a valid amount.");
                return 0;
            }

            if (amount > Cash)
            {
                Console.WriteLine(Name + " says: " + "I don't have enough cash to give you " + "$" + amount);
                return 0;
            }

            Cash -= amount;
            return amount;
        }

        /// <summary>
        /// Receive an amount of cash, adds it to wallet (or prints message to console if invalid amount).
        /// </summary>
        /// <param name="amount">Cash amount to give.</param>
        public void ReceiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + "$" + amount + " isn't an amount I'll take.");
            }
            else
            {
                Cash += amount;
            }
        }
    }
}
