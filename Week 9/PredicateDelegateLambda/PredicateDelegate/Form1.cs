using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredicateDelegateLambda
{
    public partial class Form1 : Form
    {
        List<int> list;

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            list = new List<int>();
        }

        private bool lessThanTen(int input)
        {
            if (input < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void genRandom()
        {
            int r = rand.Next(100);
            list.Add(r);
            listBox1.Items.Add(r);
        }

        private void generateBT_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            list.Clear();

            for (int i = 0; i < 100; i++)
            {
                genRandom();
            }
        }

        private void evenBT_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            Predicate<int> odd = (n) => (n % 2) == 1;

            for (int i = 0; i < list.Count; i++)
            {
                if (!odd(list[i]))
                {
                    listBox2.Items.Add(list[i]);
                }
            }
        }

        private void lessThan10BT_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            Predicate<int> belowTen = (n) => n < 10;

            for (int i = 0; i < list.Count; i++)
            {
                if (belowTen(list[i]))
                {
                    listBox2.Items.Add(list[i]);
                }
            }
        }
    }
}
