using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherObserver
{
    public class ForecastObserver : Observer
    {
        public ForecastObserver(ListBox DisplayBox, Subject Subject)
            : base(DisplayBox, Subject)
        {
        }
        public override void Update(int Temp, int Humid, int Pressure)
        {
            this.Temp = Temp;
            this.Humid = Humid;
            this.Pressure = Pressure;

            Display();
        }
        public override void Display()
        {
            
            if (Temp > 35)
            {
                DisplayBox.Items.Add("It's going to be hot");
            }
            else if (Temp < 5)
            {
                DisplayBox.Items.Add("It's going to be cold");
            }
            if (Humid > 70)
            {
                DisplayBox.Items.Add("It's going to be Humid");
            }
            else if (Humid < 10)
            {
                DisplayBox.Items.Add("It's not going to be Humid");
            }   
        }
    }
}
