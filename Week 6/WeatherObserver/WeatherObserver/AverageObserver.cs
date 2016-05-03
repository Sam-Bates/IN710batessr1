using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherObserver
{
    public class AverageObserver : Observer
    {
        public AverageObserver(ListBox DisplayBox, Subject Subject)
            : base(DisplayBox, Subject)
        {
        }
        public override void Update(int Temp, int Humid, int Pressure)
        {
            double TempAv = 0;
            double HumidAv = 0;
            double PressureAv = 0;
            int iter = 0;
            TempHistory.Add(Temp);
            HumidHistory.Add(Humid);
            PressureHistory.Add(Pressure);

            for (int i = 0; i < TempHistory.Count; i++)
            {
                TempAv += TempHistory[i];
                HumidAv+= HumidHistory[i];
                PressureAv += PressureHistory[i];
                iter = i;
            }
            if (iter != 0)
            {
                this.Temp = (int)TempAv / iter;
                this.Humid = (int)HumidAv / iter;
                this.Pressure = (int)PressureAv / iter;
            }
            Display();
        }
    }
}
