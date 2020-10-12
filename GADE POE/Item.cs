using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE
{
    class Item
    {
        protected int xPos;
        protected int yPos;
        protected int Amount;

        abstract public new string ToString();
        abstract private void randomizer(Item i);
    }
}
