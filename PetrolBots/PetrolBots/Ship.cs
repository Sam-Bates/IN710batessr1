﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBots
{
    public class Ship
    {
        public delegate void OutOfFuelEventHandler(object shipSubject, ShipLocationEventArgs e);
        public event OutOfFuelEventHandler OutOfFuelEvent;

        public delegate void FullOfFuelEventHandler(object shipSubject, EventArgs e);
        public event FullOfFuelEventHandler FullOfFuelEvent;

        public int petrol;
        public Random rand;
        public Graphics mainCanvas;
        public Point shipLocation;
        public int shipSize;
        public Color shipColour;
        public Point shipVelocity;
        public bool sailing;


        public Ship(int size, Graphics mainCanvas, Random rand)
        {
            this.shipSize = size;
            this.mainCanvas = mainCanvas;
            this.rand = rand;
            shipLocation.X = 50;
            shipLocation.Y = 50;
            petrol = 100;
            sailing = true;
            shipVelocity = new Point(rand.Next(-3, 3), rand.Next(-3, 3));

        }
        public void moveShip()
        {
            if (shipLocation.X >= (500 - shipSize * 2) || (shipLocation.X <= 1))
            {
                shipLocation.X = shipLocation.X - (shipVelocity.X * 2);
            }
            if (shipLocation.Y >= (399 - shipSize) || shipLocation.Y <= 1)
            {
                shipLocation.Y = shipLocation.Y - (shipVelocity.Y * 2);
            }

            usePetrol();
        }
        public void OnEmptyEvent()
        {
            //custom event args that holds the ship location?
            ShipLocationEventArgs e = new ShipLocationEventArgs(shipLocation);
            //custom delegate that uses that event args
            if (OutOfFuelEvent != null)
            {
                //call event passing the ship location in the eventargs
                OutOfFuelEvent(this, e);
            }
        }
        public void onFullEvent()
        {
            EventArgs e = new EventArgs();
            if (FullOfFuelEvent != null)
            {
                FullOfFuelEvent(this , e);
            }
            
        }
        public void shipCycle()
        {
            //if sailing
            if (sailing)
            {
                if (petrol == 1)
                {
                    OnEmptyEvent();
                }
            }

            //if fueling
            if (!sailing)
            {
                if (petrol == 100)
                {
                    onFullEvent();
                }
            }

        }
        public void drawShip()
        {
            //draw ship based on colour
            shipColour = Color.FromArgb(petrol, 0, 0);

            SolidBrush shipBrush = new SolidBrush(shipColour);

            mainCanvas.FillRectangle(shipBrush, shipLocation.X, shipLocation.Y, shipSize, shipSize);
        }
        public void refuel()
        {
            petrol++;
        }
        public void usePetrol()
        {
            petrol--;
        }
    }
}