using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public class InstructionsObserver : FireAlarmObserverBase
    {
        public InstructionsObserver(FireAlarmSubject subject) : base (subject)
        {

        }
        public override void FireAlarmHandlerMethod(object fireSubject, FireAlarmEventArgs fe)
        {
            String message = "Fire is " + fe.FireCategory.ToString() + ".";
            switch (fe.FireCategory)
            {
                case EFireCategory.MINOR:
                    message += " the fire extinguisher.";
                    break;
                case EFireCategory.SERIOUS:
                    message += " call the fire department.";
                    break;
                case EFireCategory.INFERNO:
                    message += " evacuate the building.";
                    break;
                default:
                    break;
            }
        }
    }
}
