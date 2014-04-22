using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Solitaire350
{

    [TestFixture]
    public class TestSolitaireGame
    {

        //Create a game of Solitaire
        [Test]
        void makeAGame()
        {
            Solitaire newGame= new Solitaire();
            Assert.IsTrue(typeof(Solitaire).IsInstanceOfType(newGame));
        }
    }
}
