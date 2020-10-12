using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE
{
    class Gold : Item
    {
        public int XPos
        {
            get { return xPos; }
            set { xPos = value; }
        }

        public int YPos
        {
            get { return yPos; }
            set { yPos = value; }
        }

        public int Amount
        {
            get { return Amount; }
            set { Amount = value; }
        }

        public Gold(int x, int y, int amount)
        {

            XPos = x;
            YPos = y;
            Amount = amount;
        }
        public override string ToString()
        {
            return "RU: " + XPos + ", " + YPos + ", " + Amount;
        }

        private override void randomizer(Item i)
        {
            
        }
    }
}
