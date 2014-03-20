using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire350
{
    public class Deck
    {
        public const int CAPACITY = 52;
        public Deck()
        {
            size = 0;
            Card[] deckOfCards = new Card[CAPACITY];

            for (int i = 0; i < Card.MAX_SUIT; i++)
            {
                for (int j = 0; j < Card.MAX_RANK; j++)
                {
                    deckOfCards[size] = new Card(Card.RankType., Card.SuitType.i);
                }
            }
            
        }

        public int size { get; private set; }
        
        public void addCard(Card cardToAdd)
        {
            if (size != CAPACITY)
            {
                deckOfCards[size] = cardToAdd;
            }
        }

        /*public bool isEqual(Card rhs)
        {
            return (rhs.Suit == Suit && rhs.Rank == Rank);
        }*/

        public Card deckOfCards { get; private set; }
       
        

    }
}
