using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public class Tapir : Animal
    {
        public Tapir()
        {
            name = "Tapir";
            family = "herbivore";
            food = "Shoots and leaves";
            picture = new System.Drawing.Bitmap("Tapir.jpg");
        }
    }
}
