using System;
using System.Collections.Generic;
using System.Linq;

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

            DisplayCards(playerCards, dealerCards);
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

        public static void DisplayCards(List<BlackjackCard> playerCards, List<BlackjackCard> dealerCards)
        {
            Console.Write("Dealer has: ");

            foreach (BlackjackCard card in dealerCards)
            {
                Console.Write("{0}, ", card.card_char);
            }

            int dealerSum = dealerCards.Sum(item => item.card_val);
            String dealerString = "Total: " + dealerSum;

            if (dealerCards.Any(i => i.card == Card._A))
            {
                dealerString += "/" + (dealerSum + 10);
            }

            Console.WriteLine(dealerString);
            Console.Write("\nPlayer has: ");

            foreach (BlackjackCard card in playerCards)
            {
                Console.Write("{0}, ", card.card_char);
            }

            int playerSum = playerCards.Sum(item => item.card_val);
            String playerString = "Total: " + playerSum;

            if (playerCards.Any(i => i.card == Card._A))
            {
                dealerString += "/" + (dealerSum + 10);
            }

            Console.WriteLine(playerString);
        }
    }
}
