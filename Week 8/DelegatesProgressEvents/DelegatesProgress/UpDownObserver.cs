using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatesProgress
{
    public class UpDownObserver : ObserverBase
    {
        public NumericUpDown nud;
        public UpDownObserver(ProgressSubject subject, NumericUpDown nud) : base (subject)
        {
            this.nud = nud;
        }

        public override void EventCode(object obj, CustomEventArgs e)
        {
            e.nud.Value++;
        }
    }
}
