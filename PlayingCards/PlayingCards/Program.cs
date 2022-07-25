using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayingCards.BL;
using PlayingCards.UI;
namespace PlayingCards
{
    class Program
    {
        static void Main(string[] args)
        {
            int scoreGame = 0;
            int finalScore = 0;
            bool gameRunning = true;
            bool gameTerminate = false;
            int counter = 0;
            while(!gameTerminate)
            {
                Deck pile = new Deck();
                Card Reference = new Card(1, 1);
                int count = 1;
                do
                {
                    pile.shuffleCard();
                    Card dealt = pile.dealCard();
                    Card playerChoice =  HighLowUI.getCard();
                    if(count == 1)
                         Reference = dealt;

                    char gameChoice = char.Parse(Console.ReadLine());
                    if (gameChoice == 'L')
                    {
                        if (playerChoice.getSuit() == dealt.getSuit())
                        {
                            if (playerChoice.getValue() < dealt.getValue())
                            {
                                Reference = dealt;
                                HighLowUI.display(playerChoice);
                                scoreGame += 1;
                            }
                        }
                        else
                            HighLowUI.displayWrongMessage();
                    }
                    else if (gameChoice == 'H')
                    {
                        if (playerChoice.getSuit() == dealt.getSuit())
                        {
                            if (playerChoice.getValue() > dealt.getValue())
                            {
                                Reference = dealt;
                                HighLowUI.display(playerChoice);
                                scoreGame += 1;
                            }
                        }
                        else
                            HighLowUI.displayWrongMessage();
                    }
                    gameRunning = HighLowUI.getStoppingCondition();
                    if (!gameRunning)
                        gameTerminate = true;
                } while (gameRunning) ;
                HighLowUI.MessageScore(counter, scoreGame);
                finalScore = scoreGame / (counter + 1);
                
            }
            HighLowUI.MessageScore(counter, finalScore);
            
        }
    }
}
