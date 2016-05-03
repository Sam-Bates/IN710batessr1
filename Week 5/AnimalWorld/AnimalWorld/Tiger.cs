using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public class Tiger : Animal
    {
        public Tiger()
        {
            name = "Tiger";
            family = "Carnivore";
            food = "anything that moves";
            picture = new System.Drawing.Bitmap("Tiger.jpg");
        }
    }
}
