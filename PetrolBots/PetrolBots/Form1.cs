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

        
        Graphics Canvas;
        List<PetrolBot> botList;
        List<Ship> shipList;
        Random rand;
        Brush backgroundBrush;
        Point botStartlocation;

        public Form1()
        {
            InitializeComponent();

            Canvas = this.CreateGraphics();
            backgroundBrush = new SolidBrush(Color.Blue);

            botList = new List<PetrolBot>();
            shipList = new List<Ship>();

            rand = new Random();

            Ship s1 = new Ship(SHIP_SIZE, Canvas, rand);
            
            botStartlocation.X = 10;
            botStartlocation.Y = 250;
            PetrolBot b1 = new PetrolBot(Canvas, Color.Yellow, botStartlocation, s1);

            shipList.Add(s1);
            botList.Add(b1);
            timer1.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //draw the background
            Canvas.FillRectangle(backgroundBrush, 0, 0, 500, 500);

            //Move and redraw all ships in the list
            for (int i = 0; i < shipList.Count; i++)
            {
                shipList[i].shipCycle();
                shipList[i].moveShip();
                shipList[i].drawShip();
                botList[i].drawBot();
            }
        }


    }
}

