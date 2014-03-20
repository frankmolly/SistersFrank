using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire350
{
  
    public class Card
    {
        public const int MAX_SUIT = 4;
        public const int MAX_RANK = 13;
        public enum SuitType {CLUBS, DIAMONDS, HEARTS, SPADES };
        public enum RankType { ACE, TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING };

        public Card(RankType rank, SuitType suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public bool isEqual(Card rhs)
        {
            return (rhs.Suit == Suit && rhs.Rank == Rank);
        }

        public RankType Rank { get; private set; }
        public SuitType Suit { get; private set; }
    }
}

