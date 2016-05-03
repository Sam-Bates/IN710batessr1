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

            button.Click += handler;
        }
        public void CustomButtonHandler(object obj, EventArgs e)
        {
            MessageBox.Show("This is a custom Handler" + " My code is: " + code + " my type is " + this.GetType().ToString() + " I am responding to " + button.Name.ToString());
        }
        
    }
}
