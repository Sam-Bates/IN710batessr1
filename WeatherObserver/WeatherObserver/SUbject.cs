using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserver
{
    public class Subject
    {
        public List<IObserver> ObserverList;
        public List<int> History;
        public int Temp = 0;
        public int Humid = 0;
        public int Pressure = 0;

        public Subject()
        {
            ObserverList = new List<IObserver>();
            History = new List<int>();
        }
        public void AddObServer(Observer o)
        {
            ObserverList.Add(o);
        }
        public void RemoveObserver(Observer o)
        {
            ObserverList.Remove(o);
        }
        public void NotifyObservers()
        {
            foreach (IObserver  currentObserver in ObserverList)
            {
                currentObserver.Update(Temp, Humid, Pressure);
            }
        }
        public void UpdateValues(int Temp, int Humid, int Pressure)
        {
            this.Temp = Temp;
            this.Humid = Humid;
            this.Pressure = Pressure;
            NotifyObservers();
        }
    }
}
