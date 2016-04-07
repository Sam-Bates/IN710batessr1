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

            subject.UpdateEvent += handler;
        }
        public abstract void EventCode(object obj, CustomEventArgs e);
    }
}
