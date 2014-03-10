using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire350
{
    public class Deck
    {
        public Deck()
        {
            Card[] deckOfCards = new Card[0];
            size = 0;
            capacity = 52;
        }

        /*public bool isEqual(Card rhs)
        {
            return (rhs.Suit == Suit && rhs.Rank == Rank);
        }*/

        public Card deckOfCards { get; private set; }
        public int size { get; private set; }
        public int capacity { get; private set; }

    }
}
