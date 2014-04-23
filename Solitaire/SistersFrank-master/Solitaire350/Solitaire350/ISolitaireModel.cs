using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using namespace Solitaire350;

namespace NonVisualSolitaire350
{
    interface ISolitaireModel
    {
        void dealTheDeck(IDeck deck);
    }
}
