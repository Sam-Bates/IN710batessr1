using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherObserver
{
    public abstract class Observer : IObserver
    {
        protected double Temp;
        protected List<double> TempHistory;
        protected double Humid;
        protected List<double> HumidHistory;
        protected double Pressure;
        protected List<double> PressureHistory;
        protected ListBox DisplayBox;
        protected Subject Subject;

        public Observer(ListBox DisplayBox, Subject Subject)
        {
            this.DisplayBox = DisplayBox;
            this.Subject = Subject;
            TempHistory = new List<double>();
            HumidHistory = new List<double>();
            PressureHistory = new List<double>();
            Subject.AddObServer(this);
        }
        public abstract void Update(int Temp, int Humid, int Pressure);

        public virtual void Display()
        {
            DisplayBox.Items.Clear();
            DisplayBox.Items.Add("Temperature: " + Temp);
            DisplayBox.Items.Add("Humidity: " + Humid);
            DisplayBox.Items.Add("Pressure: " + Pressure);
        }
    }
}
