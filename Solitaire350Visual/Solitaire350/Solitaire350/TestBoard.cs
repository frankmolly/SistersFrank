using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Solitaire350
{
   [TestFixture]
   public class TestBoard
   {
       SolitaireGame newGame = new SolitaireGame();

       [Test]
       public void createBoard() //tests if the visual playing board is created
       {
           Assert.IsTrue(newGame.BackColor.Equals(System.Drawing.Color.DarkGreen));
           //Assert.IsTrue(newGame.BackColor.IsSystemColor);
       }

       [Test]
       public void createCardBack() //tests if the image of the card back is on the board
       {
           Assert.IsTrue(newGame.ShowIcon(pictureBox1));
       }

   }
}
