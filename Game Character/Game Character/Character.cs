using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    abstract class Character
    {
        String Name;
        //default weapon
        public Character(String Name)
        {
            this.Name = Name;
        }
        public abstract String Declaim();
    }
}
