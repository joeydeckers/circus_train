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
        // Algortime is nog niet af, ben tegen wat dingen aangelopen.

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
            while (!isAnimalListEmpty()) {
                var newWagon = new Wagon();
                for (int i = 0; i < animalsToSort.Count(); i++)
                {

                    if (animalsToSort[i].getIfAnimalInWagon() == true)
                    {
                        animalsToSort.RemoveAt(i);
                    }
                    else {
                        newWagon.addAnimal(animalsToSort[i]);
                    }

                }
                wagons.Add(newWagon);
            }
            // Ik begrijp niet waarom de applicatie meer wagonnen laat zien
            MessageBox.Show(wagons.Count().ToString());
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
