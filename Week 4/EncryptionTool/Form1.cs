﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionTool
{
    public partial class Form1 : Form
    {
        IEncryptor encryptor;
        public Form1()
        {
            InitializeComponent();
        }
        void button1_Click(object sender, EventArgs e)
        {
            if (ROT13.Checked)
            {
                encryptor = new ROT13();
            }
            else if (Reversal.Checked)
            {
                encryptor = new Reversal();
            }
            try
            {
                String input = TextBox1.Text;
                outTextBox.Clear();
                outTextBox.Text = encryptor.Encrypt(input);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please fill in the input field");
            }
        }
    }
}
