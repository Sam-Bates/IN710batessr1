﻿using System.Windows.Forms;

namespace WeatherObserver
{
    public class UnitObserver : Observer
    {
        public UnitObserver(ListBox DisplayBox, Subject Subject)
            :base (DisplayBox, Subject)
        {
            
        }
        public override void Update(int Temp, int Humid, int Pressure)
        {
            this.Temp = Temp;
            this.Humid = Humid;
            this.Pressure = Pressure;
            
            Display();
        }
    }
}
