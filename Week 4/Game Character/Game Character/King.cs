using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    class King : Character
    {
        public King(String Name)
            : base(Name)
        {
            weapon = new Mace();
        }
        public override string Declaim()
        {
            return "I am a King";
        }
        
    }
}
