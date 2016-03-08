﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public abstract class Character
    {
        public IWeapon weapon;
        private string name;

        protected string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Character(string Name, ListBox listbox)
        {
            this.Name = Name;
        }
        public string UseWeapon()
        {
            return weapon.UseWeapon();
        }
        public override String ToString()
        {
            return "My name is " + Name + "!";
        }
        public string Declaim()
        {
            return weapon.UseWeapon();
        }
    }
}
