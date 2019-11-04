using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circustTrein
{
    class Wagon
    {
        private int space = 0;
        private bool isFull = false;

        public List<Animal> wagonAnimals = new List<Animal>();
        public bool checkIfFull()
        {
            return isFull;
        }


        public void addAnimal(Animal animalToAdd) {
            if (space == 10)
            {
                isFull = true;
            }
            else
            {

            }
            else
            {
                if (animalToAdd.getType() == "Carnivoor")
                {
                    // Zorgt voor een loop die blijft lopen...
                    for(int i = 0; wagonAnimals.Count() > i; i++)
                    {
                        if(!checkAnimalSize(animalToAdd, wagonAnimals[i]))
                        {
                            wagonAnimals.Add(animalToAdd);
                            space += animalToAdd.getSize();
                            animalToAdd.setIsInWagon();
                        }
                    }
                }

            }
        }

        private bool checkAnimalSize(Animal animalToAdd, Animal animalInwagon)
        {
            if(animalToAdd.getSize() >= animalInwagon.getSize())
            {
                return true;
            }

            return false;
        }
    }


}
