using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonVisualSolitaire350
{
    class SolitaireModel : ISolitaireModel
    {
        //Number of different kinds of piles on playing board
        private int nTableauPiles_;
        private int nCardsInTableauPiles_;
        private int nCardsInStockPile_;
        private int nCardsInWastePile_;
        private int nFoundationPiles_;
    }
}
