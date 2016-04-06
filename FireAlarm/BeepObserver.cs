using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public class BeepObserver : FireAlarmObserverBase
    {
        [DllImport("Kernel32.dll")]
        public static extern bool Beep(int freq, int duration);
        public BeepObserver(FireAlarmSubject subject) : base(subject)
        {
        }

        public override void FireAlarmHandlerMethod(object fireSubject, FireAlarmEventArgs fe)
        {
            switch (fe.FireCategory)
            {
                case EFireCategory.MINOR:
                    Beep(800, 1000);
                    break;
                case EFireCategory.SERIOUS:
                    Beep(1000, 1000);
                    break;
                case EFireCategory.INFERNO:
                    Beep(1200, 1000);
                    break;
                default:
                    break;
            }
        }
    }
}

