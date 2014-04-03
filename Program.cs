using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Windows.Forms;

namespace Solitaire350
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Deck unshuffledDeck = new Deck();
            Deck shuffledDeck = new Deck();
            shuffledDeck.shuffle();
            unshuffledDeck.printDeck();
            shuffledDeck.printDeck();

            Console.ReadLine();
        }
    }
}
