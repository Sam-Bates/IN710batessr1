using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatesProgress
{
    public class CustomEventArgs : EventArgs
    {
        public NumericUpDown nud { get; set; }
        public ProgressBar progBar { get; set; }
        public TrackBar trackBar { get; set; }

        public CustomEventArgs(NumericUpDown nud, TrackBar trackBar, ProgressBar progBar)
        {
            this.nud = nud;
            this.trackBar = trackBar;
            this.progBar = progBar;
        }
    }
}
