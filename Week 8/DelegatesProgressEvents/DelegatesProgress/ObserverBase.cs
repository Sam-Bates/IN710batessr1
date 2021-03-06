﻿using System;
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
            //custom delegate
            EventHandler handler = new EventHandler(EventCode);
            //custom event args if subject needs to pass data to observer
            subject.UpdateEvent += handler;
        }
        public abstract void EventCode(object obj, EventArgs e);
    }
}
