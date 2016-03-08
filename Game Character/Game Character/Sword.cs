using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class Sword : IWeapon
    {

        public string UseWeapon()
        {
            return "I slash with my Sword!";
        }
    }
}
