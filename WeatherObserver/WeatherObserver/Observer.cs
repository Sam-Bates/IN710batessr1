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
        protected double Humid;
        protected double Pressure;
        protected ListBox DisplayBox;
        protected Subject Subject;
        protected List<int> history;

        public Observer(ListBox DisplayBox, Subject Subject)
        {
            this.DisplayBox = DisplayBox;
            this.Subject = Subject;
            Subject.AddObServer(this);
        }
        public Observer(ListBox DisplayBox, Subject Subject, List<int> history)
        {
            this.DisplayBox = DisplayBox;
            this.Subject = Subject;
            this.history = history;
        }
        public abstract void Update(int Temp, int Humid, int Pressure);

        public virtual void Display()
        {
            DisplayBox.Items.Add("Temperature: " + Temp);
            DisplayBox.Items.Add("Humidity: " + Humid);
            DisplayBox.Items.Add("Pressure: " + Pressure);
        }
    }
}
