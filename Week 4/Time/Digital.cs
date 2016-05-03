using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Time
{
    public class Digital : IClock
    {
        Label label;
        public Digital(Label label1)
        {
            
            label = label1;
            label.Visible = false;
        }

        public void updateClock()
        {
            string currentTime = DateTime.Now.ToString();
            string[] currentTimeSplit = currentTime.Split(' ');
            label.Text = currentTimeSplit[1];
        }


        public void show()
        {
            label.Visible = true;
        }

        public void hide()
        {
            label.Visible = false;
        }
    }
}
