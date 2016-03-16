using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public class Elephant : Animal
    {
        public Elephant()
        {
            name = "Elephant";
            family = "herbivore";
            food = "Plants";
            picture = new System.Drawing.Bitmap("Elephant.jpg");
        }
    }
}
