﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class King : Character, IWeapon
    {
        public King(String Name)
            : base(Name)
        {
            weapon = new Mace();
        }
    }
}
