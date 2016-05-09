using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightningFires
{
    public partial class Form1 : Form
    {
        LightningFiresDBDataContext db;
        public Form1()
        {
            InitializeComponent();
            db = new LightningFiresDBDataContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var avIntesity = db.tblStrikes.Average(s => s.strikeIntensity);
            listBox1.Items.Add(avIntesity.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var largestFires = (from f in db.tblFires
                                 orderby f.fireArea descending
                                 select f).Take(3);//thank the internet for .Take
            foreach (var item in largestFires)
            {
                listBox1.Items.Add("Fire Date: " + item.fireDate + " Fire Area: " + item.fireArea);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var pictures = from p in db.tblPictures
                           join s in db.tblStrikes
                           on p.strikeID equals s.strikeID //join tables where the ID"s are the same
                           select new { s.strikeLatitude, s.strikeLongitude, p.pictureFileName };//create anon? class

            foreach (var item in pictures)
            {
                listBox1.Items.Add("Filename: " + item.pictureFileName + " Lat: " + item.strikeLatitude + " long: " + item.strikeLongitude);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            var fireStrikes = from f in db.tblFires
                              join s in db.tblStrikes 
                              on f.fireLatitude equals s.strikeLatitude//join the tables where latitude is the same
                              where f.fireLongitude == s.strikeLongitude //check if longitude is the same
                              select f;//don't need to make anon class because we only need information about the fires, not the strikes

            listBox1.Items.Add("Fires that were caused by lightning strikes");
            foreach (var item in fireStrikes)
            {
                listBox1.Items.Add("ID: " + item.fireID + " Date: " + item.fireDate);
            }
        }
    }
}
