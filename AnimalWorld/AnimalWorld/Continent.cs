using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorld
{
    public abstract class Continent
    {
        public const int ANIMAL_COUNT = 4;

        protected ListBox displayBox;
        protected Random rd;
        protected int nAnimalTypes;
        protected Graphics graphics;
        protected IAnimalFactory animalFactory;

        protected Continent(ListBox displayBox, Random rd, Graphics graphics)
        {
            this.displayBox = displayBox;
            this.rd = rd;
            //this.nAnimalTypes = nAnimalTypes;
            this.graphics = graphics;
        }
        public void runSim()
        {
            Animal currAnimal;
            for (int i = 0; i < ANIMAL_COUNT; i++)
            {
                int animalChoice = rd.Next(ANIMAL_COUNT);

                currAnimal = animalFactory.createAnimal(animalChoice);
                graphics.DrawImage(currAnimal.Picture, 20, 20 + (i * 120));
            }
        }
    }
}
