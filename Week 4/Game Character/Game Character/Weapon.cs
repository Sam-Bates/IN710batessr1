using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public abstract class Weapon : IWeapon
    {
        protected string verb;
        protected string noun;

        public string UseWeapon()
        {
            return "I " + verb + " with my " + noun + "!";
        }
    }
}
