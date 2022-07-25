using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayingCards.BL;

namespace PlayingCards.UI
{
    class HighLowUI
    {
        public static  Card getCard()
        {   
            int suit = 0;
            while (suit <= 0 || suit > 4)
            {
                Console.WriteLine("Enter your suit(clubs/diamonds/spades/hearts)");
                string suitS = Console.ReadLine();
                switch (suitS)
                {
                    case "clubs":
                        suit = 1;
                        break;
                    case "diamonds":
                        suit = 2;
                        break;
                    case "spades":
                        suit = 3;
                        break;
                    case "hearts":
                        suit = 4;
                        break;

                    default:
                        suit = 0;
                        break;
                }
            }
            int numbers = 0;
            while(numbers <= 0 || numbers > 13)
            {
                Console.WriteLine("Enter your value(between 1 to 13)");
                numbers = int.Parse(Console.ReadLine());
            }
            Card choice = new Card(suit, numbers);
            return choice;
        }
        public static void MessageScore(int counter,int scoreGame)
        {
            Console.WriteLine("Your score in {0} round is:  {1}",counter+1,scoreGame);
        }
        public static void display(Card c)
        {
            Console.WriteLine("You predicted correctly..."+" "+c.toString());
        }
        public static bool getStoppingCondition()
        {
            string stop = "";
            Console.WriteLine("Press 0 to quit: ");
            stop = Console.ReadLine();
            switch(stop)
            {
                case "0":
                    return false;
                default:
                    return true;
            }
        }
        public static void displayWrongMessage()
        {
            Console.WriteLine("You Enter Wrong choice.");
        }
    }
}
