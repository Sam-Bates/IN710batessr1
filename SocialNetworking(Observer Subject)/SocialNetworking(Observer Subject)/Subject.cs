﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworking_Observer_Subject_
{
    public class Subject
    {
        public List<IObserver> Friends;
        public string status;
        public Subject()
        {
            Friends = new List<IObserver>();
        }
        public void AddFriend(Observer o)
        {
            Friends.Add(o);
        }
        public void RemoveFriend(Observer o)
        {
            Friends.Remove(o);
        }
        public void NotifyObservers()
        {
            foreach (IObserver currObserver in Friends)
            {
                currObserver.Update(status);
            }
        }
        public void UpdateStatus(string status)
        {
            this.status = status;
        }
    }
}
