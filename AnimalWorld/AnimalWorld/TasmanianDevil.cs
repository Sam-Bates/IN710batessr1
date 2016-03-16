using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public class TasmanianDevil : Animal
    {
        public TasmanianDevil()
        {
            name = "Tasmanian Devil";
            family = "Carnivore";
            food = "Wombats";
            picture = new System.Drawing.Bitmap("TasmanianDevil.jpg");


        }
    }
}
