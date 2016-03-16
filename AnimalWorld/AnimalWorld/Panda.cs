using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public class Panda : Animal
    {
        public Panda()
        {
            name = "Panda";
            family = " herbivore";
            food = "Bamboo";
            picture = new System.Drawing.Bitmap("Panda.jpg");
        }
    }
}
