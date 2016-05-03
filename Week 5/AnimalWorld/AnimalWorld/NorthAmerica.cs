﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorld
{
    public class NorthAmerica : Continent
    {
        public NorthAmerica(ListBox displayBox, Random rd, Graphics graphics) 
            : base(displayBox, rd, graphics)
        {
            animalFactory = new NorthAmericanAnimalFactory();
        }
    }
}
