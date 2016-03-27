using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworking_Observer_Subject_
{
    public interface IObserver
    {
        void Update();
        void Display();
    }
}
