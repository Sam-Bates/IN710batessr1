using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleObserver
{
    public class Subject
    {
        private List<Observer> observerList;
        
        public int CurrentRPM { get; set; }

        public Subject()
        {
            observerList = new List<Observer>();
        }
        public void AddObserver(Observer o)
        {
            observerList.Add(o);
        }
        public void RemoverObserver(Observer o)
        {
            observerList.Remove(o);
        }
        public void NotifyObservers()
        {
            foreach (Observer currObserver in observerList)
            {
                currObserver.Update(CurrentRPM);
            }
        }
        public void updateRPM(int currentRPM)
        {
            currentRPM = CurrentRPM;
            NotifyObservers();
        }
    }
}
