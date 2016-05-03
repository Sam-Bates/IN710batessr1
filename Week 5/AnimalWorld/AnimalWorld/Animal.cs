using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnimalWorld
{
    public abstract class Animal
    {
        protected string name;
        protected string family;
        protected string food;
        protected Bitmap picture;
        public Bitmap Picture{ get { return picture; } }
        public override string ToString()
        {
            return "I am a " + name + ", I am a " + family + ", I eat " + food;
        }
    }

}
