using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public class Groundhog : Animal
    {
        public Groundhog()
        {
            name = "Groundhog";
            family = "Herbivore";
            food = "Flowers";
            picture = new System.Drawing.Bitmap("Groundhog.jpg");


        }
    }
}
