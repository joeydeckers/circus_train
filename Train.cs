using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace circustTrein
{
    class Train
    {
        private List<Animal> animalsToSort = new List<Animal>();
        private List<Wagon> wagons = new List<Wagon>();

        public void createAnimal(AnimalSize size, string type) {
            animalsToSort.Add(new Animal(size, type));
        }

        public List<Animal> getAnimals() {
            return animalsToSort;
        }

        public List<Wagon> getWagons()
        {
            return wagons;
        }

        public void sortAnimals()
        {
            while (!isAnimalListEmpty()) {
                var newWagon = new Wagon();
                for (int i = 0; i < animalsToSort.Count(); i++)
                {

                    if (animalsToSort[i].getIfAnimalInWagon() == false)
                    {
                        newWagon.addAnimal(animalsToSort[i]);   
                    }
                    else {
                        animalsToSort.RemoveAt(i);
                    }

                }
                wagons.Add(newWagon);
            }

            MessageBox.Show("Sorting complete");

        }

        private bool isAnimalListEmpty()
        {
           if(animalsToSort.Count() == 0)
            {
                return true;
            }
            return false;
        }
    }
}
