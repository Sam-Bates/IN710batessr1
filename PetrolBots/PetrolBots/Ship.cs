using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBots
{
    public class Ship
    {
        public delegate void OutOfFuelEventHandler(object shipSubject, EventArgs e);
        public event OutOfFuelEventHandler OutOfFuelEvent;

        public Point ShipLocation;
        public Graphics mainCanvas;
        public int size;
        public Random rand;
        public Color shipColour;
        public int petrol;

        public Ship(int size, Graphics mainCanvas, Random rand)
        {
            this.size = size;
            this.mainCanvas = mainCanvas;
            this.rand = rand;
            ShipLocation.X = 50;
            ShipLocation.Y = 50;
        }
        public void moveShip()
        {
            int random = rand.Next(3);
            if (random == 0)
            {
                ShipLocation.X++;
            }
            else if (random == 1)
            {
                ShipLocation.X--;
            }
            else if (random == 2)
            {
                ShipLocation.Y++;
            }
            else if (random == 3)
            {
                ShipLocation.Y--;
            }
        }
        public void drawShip()
        {

            shipColour = Color.FromArgb(100, 0, 0);

            SolidBrush shipBrush = new SolidBrush(shipColour);

            mainCanvas.FillRectangle(shipBrush, ShipLocation.X, ShipLocation.Y, size, size);
        }
        public void refuel()
        {
            petrol++;
        }
    }
}
