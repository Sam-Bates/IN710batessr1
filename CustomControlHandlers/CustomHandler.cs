using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlHandlers
{
    public class CustomHandler
    {
        public Button button;
        public int code;

        public CustomHandler(int code, Button button)
        {
            this.code = code;
            this.button = button;

            EventHandler handler = new EventHandler(CustomButtonHandler);
        }
        public void CustomButtonHandler(object obj, EventArgs e)
        {
            MessageBox.Show("test");
        }
        
    }
}
