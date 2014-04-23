using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NonVisualSolitaire350
{
    [TestFixture]
    class TestSolitaireModel
    {
        [SetUp]
        public void setup()
        {
            //setup the playing board
            nTableauPiles_ = 7;
            nFoundationPiles_ = 4;
            nWastePile_ = 1;
            nStockPile_ = 1;
            gameModel_ = new ISolitaireModel(nTableauPiles_, nFoundationPiles_, nWastePile, nStockPile);


        }

        [Test]
        public void dealTheDeck()
        {
            //start the game by dealing the deck of cards
            gameModel_.dealTheDeck();
            Assert.IsTrue(
        }

    }
}
