using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatesProgress
{
    public class TrackBarObserver : ObserverBase
    {
        public TrackBar trackBar;
        public TrackBarObserver(ProgressSubject subject, TrackBar trackBar)
            : base(subject)
        {
            this.trackBar = trackBar;
        }

        public override void EventCode(object obj, CustomEventArgs e)
        {
            e.trackBar.Value++;
        }
    }
}
