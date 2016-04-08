using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBots
{
    public class PetrolBot
    {
        Graphics botCanvas;
        Point botCurrentLocation;
        Point botStartingLocation;
        Color colour;
        Ship ship;
        int botSize;

        public PetrolBot(Graphics canvas, Color colour, Point location, Ship ship)
        {
            this.botCanvas = canvas;
            this.colour = colour;
            this.botStartingLocation = location;
            this.botCurrentLocation = location;
            this.ship = ship;
            botSize = 10;

            //odd syntax
            ship.OutOfFuelEvent += new Ship.OutOfFuelEventHandler(OnEmptyEventCode);
            ship.FullOfFuelEvent += new Ship.FullOfFuelEventHandler(OnFullEventCode);
            
        }
        public void drawBot()
        {

            SolidBrush shipBrush = new SolidBrush(colour);

            botCanvas.FillRectangle(shipBrush, botCurrentLocation.X, botCurrentLocation.Y, botSize, botSize);
        }
        public void OnEmptyEventCode(object obj, ShipLocationEventArgs e)
        {
            botCurrentLocation.X = e.location.X;
            botCurrentLocation.Y = e.location.Y;
        }
        public void OnFullEventCode(object obj, EventArgs e)
        {
            botCurrentLocation.X = botStartingLocation.X;
            botCurrentLocation.Y = botStartingLocation.Y;
        }
    }
}
