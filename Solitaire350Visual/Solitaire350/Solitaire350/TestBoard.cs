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
       public void createStockPile() //tests if the image of the card back is on the board
       {
           Assert.AreEqual(newGame.StockPile.Image,"images/cardBackSmall.jpg");
       }

       [Test]
       public void createLeftFoundationPlaceHolder() //tests location of left place holder in foundation
        {
            const int X_FOUNDATION_LOC = 354;
            const int Y_FOUNDATION_LOC = 12;
            Assert.AreEqual(newGame.LeftFoundation.Location.X, X_FOUNDATION_LOC);
            Assert.AreEqual(newGame.LeftFoundation.Location.Y, Y_FOUNDATION_LOC);         
       }

       [Test]
       public void createCenterLeftFoundationPlaceHolder() //tests location of center left place holder in foundation
       {
           const int X_FOUNDATION_LOC = 469;
           const int Y_FOUNDATION_LOC = 12;
           Assert.AreEqual(newGame.CenterLeftFoundation.Location.X, X_FOUNDATION_LOC);
           Assert.AreEqual(newGame.CenterLeftFoundation.Location.Y, Y_FOUNDATION_LOC);
       }

       [Test]
       public void createCenterRightFoundationPlaceHolder() //tests location of center right place holder in foundation
       {
           const int X_FOUNDATION_LOC = 584;
           const int Y_FOUNDATION_LOC = 12;
           Assert.AreEqual(newGame.CenterRightFoundation.Location.X, X_FOUNDATION_LOC);
           Assert.AreEqual(newGame.CenterRightFoundation.Location.Y, Y_FOUNDATION_LOC);
       }

       [Test]
       public void createRightFoundationPlaceHolder() //tests location of far right place holder in foundation
       {
           const int X_FOUNDATION_LOC = 699;
           const int Y_FOUNDATION_LOC = 12;
           Assert.AreEqual(newGame.RightFoundation.Location.X, X_FOUNDATION_LOC);
           Assert.AreEqual(newGame.RightFoundation.Location.Y, Y_FOUNDATION_LOC);
       }


   }    
}
