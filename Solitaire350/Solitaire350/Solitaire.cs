using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire350
{
    public class Solitaire
    {
        //Constructor of a Solitaire Game
        public Solitaire()
        {
            gameTableauPiles_ = new TableauPiles(7);

        }
            
        public void playGame();

        private TableauPiles gameTableauPiles_;
        private Deck gameDeck_();

    }
}
