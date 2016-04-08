using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PetrolBots
{
    public class ShipLocationEventArgs : EventArgs
    {
        public Point location { get; set; }
        public ShipLocationEventArgs(Point location)
        {
            this.location = location;
        }
    }
}
