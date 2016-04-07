using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProgress
{
    public abstract class ObserverBase
    {
        ProgressSubject subject;
        public ObserverBase(ProgressSubject subject)
        {
            this.subject = subject;

            EventHandler handler = new EventHandler(EventCode);

            subject.OnUpdateEvent += handler;
        }
        public abstract void EventCode(object obj, EventArgs e);
    }
}
