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

        private Card[] deckOfCards_ = new Card[CAPACITY];

        public Deck()
        {
            size = 0;
            
            for (int i = 0; i < Card.MAX_SUIT; i++)
            {
                for (int j = 0; j < Card.MAX_RANK; j++)
                {
                    deckOfCards_[size] = new Card((Card.RankType) j, (Card.SuitType) i);
                    size++;
                }
            }

        }

        //swaps the position of two cards in the deck
        public void swap(int lhs, int rhs)
        {
            Card tempCard = new Card(deckOfCards_[lhs]);
            deckOfCards_[lhs] = deckOfCards_[rhs];
            deckOfCards_[rhs] = tempCard;
        }

        //overrides [] operator for Deck
        public Card this[int index]
        {
            get
            {
                return deckOfCards_[index];
            }
            set
            {
                deckOfCards_[index] = value;
            }
        }

        public void shuffle()
        {
            Random randomNumber = new Random();
            
            for (int card = 0; card < CAPACITY; ++card)
            {
                swap(card, randomNumber.Next(CAPACITY));
            }
        }

        public void printDeck()
        {
            for(int i=0;i<size;i++)
            {
                Console.WriteLine("{0}", deckOfCards_[i]);
            }
        }

        public int size { get; private set; }

        //public Card[] deckOfCards_ { get; private set; }

        
        

    }
}
