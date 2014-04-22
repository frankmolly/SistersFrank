using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire350
{
    public class TableauPiles
    {

        //How should the tableau piles be implemented? As a 2D array filled with Cards? 
        public TableauPiles(int howManyPiles)
        {
            howManyPiles_ = howManyPiles;

            Card NULLCARD = new Card(Card.RankType.NULLRANK, Card.SuitType.NULLSUIT);
            for (int pile = 0; pile < howManyPiles_; pile++)
            {
                for (int cardInPile = 0; cardInPile < Card.MAX_RANK; cardInPile++)
                {
                    //go through in and fill in each tableau pile with a null card
                    Piles_[cardInPile, pile] = new Card(NULLCARD);
                }
            }
        }

        private Card[,] Piles_ = new Card[Card.MAX_RANK, 52]; //Piles_ is a private data member 
                                                              //which is a 2D Array of cards

        //add card to a tableau pile
        public void AddCardToPile(Card cardToAdd, int whichPile)
        {
            Card NULLCARD = new Card(Card.RankType.NULLRANK, Card.SuitType.NULLSUIT);
            int currentCard = 0;
            //Find the top of that pile
            while (!(NULLCARD.isEqual(Piles_[currentCard, whichPile])))
            {
                ++currentCard;
            }

            Piles_[currentCard,whichPile] = new Card(cardToAdd); //place card in that spot
        }

        //overrides [] operator for TableauPiles
        public TableauPiles this[int numOfCardInPile, int PileNum]
        {
            get
            {
                Card retCard = new Card(Piles_[numOfCardInPile, PileNum]);
                return retCard;
            }
            set
            {
                Piles_[numOfCardInPile, PileNum] = value;
            }
        }

        public int howManyPiles_ { get; private set; }
        
    }
}
