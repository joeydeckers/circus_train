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
        public int _id;

        public List<Animal> wagonAnimals = new List<Animal>();

        public Wagon(int id)
        {
            _id = id;
        }

        public void addAnimal(Animal animalToAdd) {
            space += animalToAdd.points;
            animalToAdd.isInWagon = true;
            wagonAnimals.Add(animalToAdd);
        }

        public bool Calculate(Animal animalToAdd){
            if (!IsSpaceAvailable())
            {
                return false;
            }

            var check = wagonAnimals.Where(animal => animalToAdd.points >= animal.points && animalToAdd.Type == AnimalType.carnivore);
            if (check.Any())
            {
                return false;
            }
            return true;
        }

        private bool IsSpaceAvailable()
        {
            if(space == 10)
            {
                return false;
            }
            return true;
        }

    }


}
