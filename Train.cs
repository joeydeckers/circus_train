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

        public List<Animal> GetAnimals() {
            return animalsToSort;
        }

        public List<Wagon> GetWagons()
        {
            return wagons;
        }

        public void sortAnimals()
        {
            var newWagon = new Wagon(1);

            foreach (var animalToAdd in animalsToSort)
            {
                if (newWagon.Calculate(animalToAdd) == true)
                {
                    newWagon.addAnimal(animalToAdd);
                }
                else
                {
                   // MessageBox.Show(wagons.Count().ToString());
                    newWagon = new Wagon(wagons.Count() +1);
                    newWagon.addAnimal(animalToAdd);
                    wagons.Add(newWagon);

                }
            }
            wagons.Add(newWagon);

            MessageBox.Show(wagons.Count().ToString());
        }
    }
}
