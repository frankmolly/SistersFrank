using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Solitaire350
{
    
    [TestFixture]
    public class TestTableauPiles
    {
        [Test]
        public void createTableau()
        {
            TableauPiles myTableau = new TableauPiles(7);
            Assert.IsTrue(typeof(TableauPiles).IsInstanceOfType(myTableau));
        }

        [Test]
        public void isTableauFilledWithNullCards()
        {
            TableauPiles myTableau = new TableauPiles(7);
            Card NULLCARD = new Card(Card.RankType.NULLRANK, Card.SuitType.NULLSUIT);
            Assert.IsEqual(myTableau[0,0].Rank, 
        }

    }
}
