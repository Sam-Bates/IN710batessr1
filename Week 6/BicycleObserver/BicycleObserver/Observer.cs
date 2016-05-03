using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleObserver
{
    public abstract class Observer : IObserver
    {
        protected int currentRPM;
        protected double currentComputedValue;
        protected Label displayLabel;
        protected Subject subject;

        public Observer(Label displayLabel, Subject subject)
        {
            this.displayLabel = displayLabel;
            currentRPM = 0;
            currentComputedValue = 0;
            this.subject = subject;

            subject.AddObserver(this);
        }
        public abstract void Update(int currentRPM);

        public void Display()
        {
            displayLabel.Text = currentComputedValue.ToString("F2");
        }
    }
}
