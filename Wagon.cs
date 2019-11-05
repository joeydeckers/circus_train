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
        public List<Animal> wagonAnimals = new List<Animal>();

        public void AddAnimal(Animal animalToAdd) {
            space += animalToAdd.points;
            animalToAdd.isInWagon = true;
            wagonAnimals.Add(animalToAdd);
            //MessageBox.Show(space.ToString());
        }

        public bool Calculate(Animal animalToAdd){
            if (!IsSpaceAvailable())
            {
                return false;
            }

            var condition = wagonAnimals.Where(animal => animalToAdd.points >= animal.points && animalToAdd.Type == AnimalType.carnivore || animal.points >= animalToAdd.points && animal.Type == AnimalType.carnivore);
         
            if (condition.Any())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsSpaceAvailable()
        {
            if(space == 10)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return space.ToString();
        }
    }


}
