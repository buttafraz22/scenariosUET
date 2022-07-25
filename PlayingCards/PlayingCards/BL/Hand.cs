using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayingCards.BL;

namespace PlayingCards.BL
{
    class Hand
    {
        private List<Card> cards;
        public List<Card> diamond;
        public List<Card> heart;
        public List<Card> spades;
        public List<Card> clubs;
        public List<Card> cardsByValue;
        public Hand()
        {
            cards = new List<Card>();
            diamond = new List<Card>();
            heart = new List<Card>();
            spades = new List<Card>();
            clubs = new List<Card>();
            cardsByValue = new List<Card>();
        }
        public void clearHand()
        {
            cards.Clear();
        }
        public void removeCard(Card c)
        {
            foreach(Card f in  cards)
            {
                if (f.getSuit() == c.getSuit() && f.getValue() == c.getValue())
                    cards.Remove(f);
            }
        }
        public void removeCardAtPosition(int position)
        {
            cards.RemoveAt(position);
        }
        public int getCardCount()
        {
            return cards.Count;
        }
        public Card getCardAtPosition(int position)
        {
            return cards[position - 1];
        }
        public void sortBySuit()
        {
            foreach(Card c in cards)
            {
                if(c.getSuit() == 1)
                {
                    clubs.Add(c);
                }
            }
            foreach (Card c in cards)
            {
                if (c.getSuit() == 2)
                {
                    diamond.Add(c);
                }
            }
            foreach (Card c in cards)
            {
                if (c.getSuit() == 3)
                {
                    spades.Add(c);
                }
            }
            foreach (Card c in cards)
            {
                if (c.getSuit() == 4)
                {
                    heart.Add(c);
                }
            }
            clubs = clubs.OrderBy(o => o.getValue()).ToList();
            diamond = diamond.OrderBy(o => o.getValue()).ToList();
            heart = heart.OrderBy(o => o.getValue()).ToList();
            spades = spades.OrderBy(o => o.getValue()).ToList();
        }
        public void sortByValue()
        {
            sortBySuit();
            for(int i = 0; i< 52; i++)
            {
                cardsByValue.Add(clubs[i]);
                cardsByValue.Add(diamond[i]);
                cardsByValue.Add(spades[i]);
                cardsByValue.Add(heart[i]);
            }
        }
    } // end hand class
}
