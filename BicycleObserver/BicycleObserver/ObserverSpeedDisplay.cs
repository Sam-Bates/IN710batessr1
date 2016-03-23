using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleObserver
{
    public class ObserverSpeedDisplay : Observer
    {
        public ObserverSpeedDisplay(Label displayLabel, Subject bikeSubject)
            : base(displayLabel, bikeSubject)
        {
        }
        public override void Update(int currentRPM)
        {
            currentComputedValue = ((currentRPM * 2.05) * 60) * 0.001;
            Display();
        }
    }
}
