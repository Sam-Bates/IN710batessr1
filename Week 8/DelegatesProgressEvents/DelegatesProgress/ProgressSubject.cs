using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatesProgress
{
    public class ProgressSubject
    {
        //observers bind code to this event
        public event EventHandler UpdateEvent;
        //public EventArgsWithData
        NumericUpDown nud;
        TrackBar trackBar;
        ProgressBar progBar;

        public ProgressSubject(NumericUpDown nud, TrackBar trackBar, ProgressBar progBar)
        {
            this.nud = nud;
            this.trackBar = trackBar;
            this.progBar = progBar;
        }
        public void SlowMethod()
        {
            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(500);
                OnUpdateEvent();
            }
        }
        public void OnUpdateEvent()
        {
            CustomEventArgs e = new CustomEventArgs(nud, trackBar, progBar);
            if (UpdateEvent != null)
            {
                UpdateEvent(this, e);
            }
        }
    }
}
