using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayingCards.BL;
namespace PlayingCards.BL
{
     class Deck
    {
        public List<Card> PlayingDeck ;
        public List<Card> shuffled;
        public Deck()
        {
           
            this.PlayingDeck = new List<Card>();
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 52; j++)
                {
                    Card card1 = new Card(i, j);
                    PlayingDeck.Add(card1);
                }
            }
            this.shuffled = new List<Card>();
        }
        public  void shuffleCard()
        {
            
            while(shuffled.Count != 52)
            {
                Random rnd = new Random();
                int randomPick = rnd.Next(0, PlayingDeck.Count - 1);
                Card shuffledC = PlayingDeck[randomPick];
                if (!isCardExists(shuffled, shuffledC))
                    shuffled.Add(shuffledC);
            }
            //return shuffled;
        }
        public bool isCardExists(List<Card>s,Card c)
        {
            foreach(var f in s)
            {
                if (c.getValue() == f.getValue() && c.getSuit() == f.getSuit())
                    return true;
            }
            return false;
        }
        public Card dealCard()
        {
            Card deal = shuffled[shuffled.Count - 1];
            shuffled.RemoveAt(shuffled.Count - 1);

            return deal;
        }
    } // end deck class
}
