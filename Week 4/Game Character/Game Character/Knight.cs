using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    class Knight : Character
    {
        public Knight(String Name)
            : base(Name)
        {
            weapon = new Sword();
        }
        public override string Declaim()
        {
            return "I am a Knight";
        }
    }
}
