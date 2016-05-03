using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleObserver
{
    public class Subject : ISubject
    {
        private List<IObserver> observerList;
        
        public int CurrentRPM { get; set; }

        public Subject()
        {
            observerList = new List<IObserver>();
        }
        public void AddObserver(IObserver o)
        {
            observerList.Add(o);
        }
        public void RemoveObserver(IObserver o)
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
