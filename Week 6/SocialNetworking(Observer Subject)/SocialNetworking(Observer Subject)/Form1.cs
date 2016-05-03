using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetworking_Observer_Subject_
{
    public partial class Form1 : Form
    {
        Subject subject;
        Friend friend1;
        Friend friend2;
        Friend friend3;
        public DateTime date;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            subject = new Subject();
            friend1 = new Friend(listBox2, subject, date);
            friend2 = new Friend(listBox3, subject, date);
            friend3 = new Friend(listBox4, subject, date);
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            date = DateTime.Now;
            string status = textBox1.Text;

            subject.UpdateStatus(status, date);

            listBox1.Items.Add(date);
            listBox1.Items.Add(status);
        }
    }
}
