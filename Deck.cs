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

        [Test]
        public void printCard() //tests our print card function
        {
            Card myCard = new Card(Card.RankType.ACE, Card.SuitType.SPADES);
            myCard.printCard();
        }
    }

    [TestFixture]
    public class TestDeck
    {
        const int DECK_SIZE = 52;

         [Test]
        public void createDeck() //tests that a deck can be created with ability
                                //to hold 52 cards
        {
            Card[] newDeck = new Card[DECK_SIZE]; 
            Deck myDeck = new Deck();
            Assert.AreEqual(myDeck.size, DECK_SIZE);
            Assert.Contains
        }


         [Test]
         public void swap()
         {
             Deck myDeck = new Deck();
             Deck swappedCards = new Deck();
             swappedCards.swap(0,1);
             Assert.AreNotEqual(myDeck[0], swappedCards[0]);
             Assert.AreNotEqual(myDeck[1], swappedCards[1]);
             Assert.AreEqual(myDeck[0], swappedCards[1]);
             Assert.AreEqual(myDeck[1], swappedCards[0]);
         }

         [Test]
         public void shuffle() //tests to see if the cards are being randomly shuffled
         {
             Deck unshuffledDeck = new Deck();
             Deck shuffledDeck = new Deck();
             shuffledDeck.shuffle();
             Assert.AreNotEqual(unshuffledDeck, shuffledDeck); //a shuffled and an unshuffled deck should not be equal
         }

        
    }

    
}
