using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circustTrein
{
    public class Wagon
    {
        private int space;

        private List<Animal> wagonAnimals = new List<Animal>();
        // intern toevoegen
        public void AddAnimal(Animal animalToAdd) {
            space += animalToAdd.points;
            wagonAnimals.Add(animalToAdd);
        }

        public List <Animal> GetAnimals()
        {
            return wagonAnimals;
        }

        public bool Calculate(Animal animalToAdd){
            if (!IsSpaceAvailable())
            {
                return false;
            }

            if (!CheckAnimalToAddSize(animalToAdd) & !CheckAnimalToAddType(animalToAdd))
            {
                return false;
            }

            if (!CheckAnimalInsideSize(animalToAdd) & !CheckAnimalInsideType(animalToAdd))
            {
                return false;
            }
            else
            {
                AddAnimal(animalToAdd);
                return true;
            }
        }

        private bool CheckAnimalToAddSize(Animal animalToAdd)
        {
            var condition = wagonAnimals.Where(animal => animalToAdd.points >= animal.points);
            if (condition.Any())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CheckAnimalToAddType(Animal animalToAdd)
        {
            var condition = wagonAnimals.Where(animal => animalToAdd.Type == AnimalType.carnivore);
            if (condition.Any())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CheckAnimalInsideSize(Animal animalToAdd)
        {
            var condition = wagonAnimals.Where(animal => animal.points >= animalToAdd.points);

            if (condition.Any())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CheckAnimalInsideType(Animal animalToAdd)
        {
            var condition = wagonAnimals.Where(animal => animal.Type == AnimalType.carnivore);

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
            //MessageBox.Show(space.ToString());
            if(space == 10)
            {
                MessageBox.Show("Vol!");
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return "Wagon";
        }
    }


}
