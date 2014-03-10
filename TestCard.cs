using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Solitaire350
{
    [TestFixture]
    public class TestCard
    {
        [Test]
        public void createCard() //tests that a card can be created of a designated suit and rank
        {
            //const int MY_CARD_RANK = 3;
            Card myCard = new Card(Card.RankType.ACE, Card.SuitType.CLUBS); //created a card of rank ace and suit clubs
            Assert.AreEqual(myCard.Suit, Card.SuitType.CLUBS); //assert that the card's suit is equal to clubs
            Assert.AreEqual(myCard.Rank, Card.RankType.ACE); //assert that the card's rank is equal to ace
        }


        [Test]
        public void equalCards() //tests that two cards of the same type and rank are the same
        {
            Card myCard = new Card(Card.RankType.THREE, Card.SuitType.CLUBS);
            Card yourCard = new Card(Card.RankType.THREE, Card.SuitType.CLUBS);
            Assert.IsTrue(myCard.isEqual(yourCard));
        }
    }
    
    [TestFixture]
    public class TestDeck
    {
         [Test]
        public void createDeck() //tests that a deck can be created with 52 cards
        {
            const int capacity = 52;
            const int size = 0;
            Card[] newDeck = new Card[size];
            Deck myDeck = new Deck();
            Assert.AreEqual(myDeck.capacity, capacity);
            Assert.AreEqual(myDeck.size, size);
            //Assert.AreEqual(myDeck.deckOfCards, newDeck); 
        }

    }
}


    
       