using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    class Queen : Character
    {
        public Queen(String Name, ListBox listbox)
            : base(Name, listbox)
        {
            weapon = new Bow();
        }
        public override string Declaim()
        {
            return "I am a Queen";
        }
    }
}
