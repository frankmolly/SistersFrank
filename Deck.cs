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
                    deckOfCards[size] = new Card((Card.RankType) j, (Card.SuitType) i);
                    ++size;
                }
            }

        }

        //public void printDeck()
        //{
        //    for(int i=0;i<size;i++)
        //    {
        //        Console.WriteLine("{0}", deckOfCards[i]);
        //    }
        //}

        public int size { get; private set; }

        public Card deckOfCards { get; private set; }
       
        

    }
}
