using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class AsianAnimalFactory : IAnimalFactory
    {

        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch (animalCode)
            {
                case 0:
                    newAnimal = new Panda();
                    break;
                case 1:
                    newAnimal = new Elephant();
                    break;
                case 2:
                    newAnimal = new Tiger();
                    break;
                case 3:
                    newAnimal = new Tapir();
                    break;
            }
            return newAnimal;
        }
    }
}
