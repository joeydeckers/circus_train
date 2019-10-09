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

        public void createAnimal(int size, string type) {
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
            var newWagon = new Wagon();

            wagons.Add(newWagon);

            while (!isAnimalListEmpty()) {
                for (int i = 0; i < animalsToSort.Count(); i++)
                {

                    if (newWagon.getWagonSpace() == 10) {
                        MessageBox.Show("full");
                    }

                    foreach(var wagon in wagons)
                    {
                        MessageBox.Show("Animal added");

                        wagon.addAnimal(animalsToSort[i]);
                        animalsToSort.RemoveAt(i);
                    }
                   

                }

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
