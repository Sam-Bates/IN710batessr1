using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatesProgress
{
    public class ProgressBarObserver : ObserverBase
    {
        public ProgressBar pgb;
        public ProgressBarObserver(ProgressSubject subject, ProgressBar pgb)
            : base(subject)
        {
            this.pgb = pgb;
        }

        public override void EventCode(object obj, EventArgs e)
        {
            pgb.Value++;
        }
    }
}
