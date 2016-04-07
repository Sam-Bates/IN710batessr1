﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProgress
{
    public class ProgressSubject
    {
        //observers bind code to this event
        public event EventHandler UpdateEvent;

        public void SlowMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(500);
                OnUpdateEvent();
            }
        }
        public void OnUpdateEvent()
        {
            EventArgs e = new EventArgs();
            if (UpdateEvent != null)
            {
                UpdateEvent(this, e);
            }
        }
    }
}
