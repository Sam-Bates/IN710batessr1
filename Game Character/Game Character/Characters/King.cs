using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    class King : Character, IWeapon
    {
        public King(String Name, ListBox listbox)
            : base(Name, listbox)
        {
            weapon = new Mace();
        }
    }
}
