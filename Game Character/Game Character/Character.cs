using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    abstract class Character
    {
        public IWeapon weapon;
        protected string Name
        {
            get { return Name; }
            set { Name = value; }
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
            return "My name is " + Name + "!";
        }
    }
}
