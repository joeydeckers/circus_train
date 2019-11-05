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

        public void createAnimal(AnimalSize size, AnimalType type) {
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
            //while (!isAnimalListEmpty()) {
            //    var newWagon = new Wagon();

            //    for (int i = 0; i < animalsToSort.Count(); i++)
            //    {
            //        if (animalsToSort[i].isInWagon == true)
            //        {
            //            animalsToSort.RemoveAt(i);

            //        }
            //        else
            //        {
            //            newWagon.addAnimal(animalsToSort[i]);
            //        }

            //    }
            //    wagons.Add(newWagon);
            //}
            var newWagon = new Wagon();

            foreach (var animal in animalsToSort)
            {
                if (!animal.isInWagon == true)
                {
                    newWagon.addAnimal(animal);
                }
                else
                {
                    newWagon = new Wagon();
                    wagons.Add(newWagon);
                    newWagon.addAnimal(animal);
                }
            }
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
