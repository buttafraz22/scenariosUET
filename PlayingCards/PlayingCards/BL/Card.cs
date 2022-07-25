using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards.BL
{
    public class Card
    {
        private int suit;
        private int numbers;
        public Card(int suit, int numbers)
        {
            this.suit = suit;
            this.numbers = numbers;
        }
        public int getValue()
        {
            return numbers;
        }
        public int getSuit()
        {
            return suit;
        }
        public string getSuitAsString()
        {
            string suitR = "";
            switch(suit) // obtaining the value of suit instance represented as string
            {
                case 1:
                    suitR = "clubs";
                    return suitR;

                case 2:
                    suitR = "diamonds";
                    return suitR;

                case 3:
                    suitR = "spades";
                    return suitR;

                case 4:
                    suitR = "hearts";
                    return suitR;
            }
            return null;
        }
        public string getValueAsString() // obtaining the value of card as a string
        {
            switch(numbers)
            {
                case 1:
                    return "ace";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                case 10:
                    return "ten";
                case 11:
                    return "jack";
                case 12:
                    return "queen";
                case 13:
                    return "king";

            }
            return null;
        }
        public string toString() // return the complete value of card as a string
        {
            string cardVal = "";
            
            cardVal += getValueAsString(); // concatenating the suit and value in a string
            cardVal += " of ";
            cardVal += getSuitAsString();

            return cardVal;
        }
    } // end class card
}
