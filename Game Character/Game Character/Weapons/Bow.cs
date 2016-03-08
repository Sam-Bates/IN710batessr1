using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class Bow : IWeapon
    {

        public string UseWeapon()
        {
            return "I shoot with my Bow!";
        }
    }
}
