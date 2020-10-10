using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class Blackjack
    {
        public static void Main(string[] args)
        {
            InitializeGame();

            List<BlackjackCard> playerCards = new List<BlackjackCard>
            {
                new BlackjackCard(),
                new BlackjackCard()
            };

            List<BlackjackCard> dealerCards = new List<BlackjackCard>
            {
                new BlackjackCard(),
                new BlackjackCard()
            };




        }

        public static void InitializeGame()
        {
            Console.WriteLine("Welcome to Blackjack! Here are the controls: \n");

            Console.WriteLine("Press 1 to hit");
            Console.WriteLine("Press 2 to stand");
            Console.WriteLine("Press 3 to double\n");

            Console.WriteLine("Start the game by pressing ENTER");

            while (Console.ReadKey(true).Key != ConsoleKey.Enter);  
        }
    }
}
