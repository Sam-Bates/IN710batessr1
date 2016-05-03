using System;
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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public IWeapon Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }
        public Character(string Name)
        {
            this.Name = Name;
        }
        public string UseWeapon()
        {
            return weapon.UseWeapon();
        }
        public override String ToString()
        {
            return nameCall() + "," + Declaim() + "," + UseWeapon(); 
        }
        public string nameCall()
        {
            return "My name is " + Name + "!";
        }
        public abstract string Declaim();
    }
}
