using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire350
{
    public class Deck : IEnumerable<Card>
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
                    deckOfCards[size] = new Card((Card.RankType) j, (Card.SuitType) i);
                    ++size;
                }
            }

        }

        ////swaps the position of two cards in the deck
        //public void swap(int lhs, int rhs)
        //{
        //    Card tempCard = new Card(deckOfCards[lhs]);

        //}


        //public void shuffle()
        //{
        //    Deck shuffledDeck = new Deck();
        //    Random randomNumber = new Random();
        //    for (int card = 0; card < Deck.CAPACITY; ++card)
        //    {

        //    }
        //}

        //public void printDeck()
        //{
        //    for(int i=0;i<size;i++)
        //    {
        //        Console.WriteLine("{0}", deckOfCards[i]);
        //    }
        //}

        public int size { get; private set; }

        public Card deckOfCards { get; private set; }

        //public Deck deckOfCards[int i]
        //{
        //    get
        //    {
        //        return deckOfCards[i];
        //    }
        //    private set
        //    {
        //        deckOfCards[i] = value;
        //    }
        //}

        public class DeckEnumerator : IEnumerator<Deck>
        {
            private Deck _collection;
            private int index;
            private Card someCard;

            public DeckEnumerator(Deck collection)
            {
                _collection = collection;
                index = -1;
                someCard = default(Card);
            }

            public bool MoveNext()
            {
                someCard = _collection.Count();

                return someCard != null;
            }

            public void Reset() { index = -1; }

            void IDisposable.Dispose() { }

            public Card Current
            {
                get { return index; }
            }

            object IEnumerator<Deck>.Current
            {
                get { return Current; }
            }
        }
    }
}
