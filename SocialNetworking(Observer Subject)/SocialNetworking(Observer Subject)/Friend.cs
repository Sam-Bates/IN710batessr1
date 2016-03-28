using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetworking_Observer_Subject_
{
    public class Friend : Observer
    {
        public Friend(ListBox DisplayBox, Subject Subject, DateTime date)
            : base (DisplayBox, Subject, date)
        {
        }
    }
}
