using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetworking_Observer_Subject_
{
    public abstract class Observer : IObserver
    {
        protected ListBox DisplayBox;
        protected Subject Subject;
        protected string status;
        protected DateTime date;

        public Observer(ListBox DisplayBox, Subject Subject, DateTime date)
        {
            this.DisplayBox = DisplayBox;
            this.Subject = Subject;
            this.date = date;
            Subject.AddFriend(this);
        }
        public void Update(string status, DateTime date)
        {
            this.status = status;
            this.date = date;
            Display();
        }
        public void Display()
        {
            DisplayBox.Items.Add(date);
            DisplayBox.Items.Add(status);
        }
    }
}
