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
                space += animalToAdd.points;
                animalToAdd.isInWagon = true;
                MessageBox.Show(space.ToString());
            }
        }

        private bool checkAnimalSize(Animal animalToAdd, Animal animalInwagon)
        {
            if(animalToAdd.points >= animalInwagon.points)
            {
                return true;
            }

            return false;
        }
    }


}
