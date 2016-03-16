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
        protected Graphics canvas;
        protected IAnimalFactory animalFactory;

        protected Continent(ListBox displayBox, Random rd, Graphics canvas)
        {
            this.displayBox = displayBox;
            this.rd = rd;
            this.canvas = canvas;
        }
        public void runSim()
        {
            Animal currAnimal;
            displayBox.Items.Clear();
            for (int i = 0; i < ANIMAL_COUNT; i++)
            {
                int animalChoice = rd.Next(ANIMAL_COUNT);

                currAnimal = animalFactory.createAnimal(animalChoice);
                canvas.DrawImage(currAnimal.Picture, 20,20  + (i * 120), 150, 100);
                displayBox.Items.Add(currAnimal);
            }
        }
    }
}
