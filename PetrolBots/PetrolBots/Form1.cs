using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolBots
{
    public partial class Form1 : Form
    {
        public const int SHIP_SIZE = 50;
        public const int BOT_SIZE = 10;

        
        Graphics mainCanvas;
        List<PetrolBot> botList;
        List<Ship> shipList;
        Random rand;
        Brush backgroundBrush;

        public Form1()
        {
            InitializeComponent();

            mainCanvas = CreateGraphics();
            backgroundBrush = new SolidBrush(Color.White);

            botList = new List<PetrolBot>();
            shipList = new List<Ship>();

            rand = new Random();

            Ship s1 = new Ship(SHIP_SIZE, mainCanvas, rand);

            shipList.Add(s1);

        }

        public void tick()
        {
            mainCanvas.FillRectangle(backgroundBrush, 0, 0, 500, 500);

            //Move & redraw all ships in the list
            for (int i = 0; i < shipList.Count; i++)
            {
                shipList[i].moveShip();
                shipList[i].drawShip();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick();
        }
    }
}

