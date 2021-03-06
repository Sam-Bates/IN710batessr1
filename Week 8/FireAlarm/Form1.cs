﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarm
{
    public partial class Form1 : Form
    {
        public FireAlarmSubject subject;
        public InstructionsObserver instObserver;
        public BeepObserver beepObserver;
        EFireCategory currentFire;

        public Form1()
        {
            InitializeComponent();
            subject = new FireAlarmSubject();
            instObserver = new InstructionsObserver(subject);
            beepObserver = new BeepObserver(subject);
        }

        private void fireBT_Click(object sender, EventArgs e)
        {
            if (minorRB.Checked)
            {
                subject.OnFireEvent(EFireCategory.MINOR);
            }
            else if (seriousRB.Checked)
            {
                subject.OnFireEvent(EFireCategory.SERIOUS);
            }
            else if (infernoRB.Checked)
            {
                subject.OnFireEvent(EFireCategory.INFERNO);
            }
        }
    }
}
