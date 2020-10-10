using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public class BlackjackCard
    {
        public String card_char { get; set; }
        public int card_val { get; set; }

        public Card card { get; set; }

        public BlackjackCard()
        {
            Random random = new Random();
            card_val = random.Next(2, 15);
            
            switch (card_val)
            {
                case 2:
                    card_char = "2";
                    card = Card._2;
                    break;
                case 3:
                    card_char = "3";
                    card = Card._3;
                    break;
                case 4:
                    card_char = "4";
                    card = Card._4;
                    break;
                case 5:
                    card_char = "5";
                    card = Card._5;
                    break;
                case 6:
                    card_char = "6";
                    card = Card._6;
                    break;
                case 7:
                    card_char = "7";
                    card = Card._7;
                    break;
                case 8:
                    card_char = "8";
                    card = Card._8;
                    break;
                case 9:
                    card_char = "9";
                    card = Card._9;
                    break;
                case 10:
                    card_char = "10";
                    card = Card._10;
                    break;
                case 11:
                    card_char = "J";
                    card = Card._J;
                    break;
                case 12:
                    card_char = "Q";
                    card = Card._Q;
                    break;
                case 13:
                    card_char = "K";
                    card = Card._K;
                    break;
                case 14:
                    card_char = "A";
                    card = Card._A;
                    break;
                
                default:
                    card_char = (card_val + 48).ToString();
                    card = Card._J;
                    break;
            }
        }
    }

    public enum Card
    {
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _8 = 8,
        _9 = 9,
        _10 = 10,
        _J = 11,
        _Q = 12,
        _K = 13,
        _A = 14
    }
}
