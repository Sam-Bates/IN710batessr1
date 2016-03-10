using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    public class Analog : IClock
    {
        AnalogClockControl.AnalogClock analog;
        public Analog()
        {
            analog = new AnalogClockControl.AnalogClock();
            analog.Visible = false;
        }
        public void updateClock()
        {
           
        }
        public void show()
        {
            analog.Visible = true;
        }

        public void hide()
        {
            analog.Visible = false;
        }
    }
}
