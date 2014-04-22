using System;
namespace Solitaire350
{
    interface ICard
    {
        bool isEqual(Card rhs);
        void printCard();
        Card.RankType Rank { get; }
        Card.SuitType Suit { get; }
    }
}
