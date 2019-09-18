using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace circustTrein
{
    class App
    {
        private List<Animal> animals = new List<Animal>();
        private List<Wagon> wagons = new List<Wagon>();

        public void createAnimal(int size, string type) {
            animals.Add(new Animal(size, type));
        }

        public List<Animal> getAnimals() {
            return animals;
        }

        public List<Wagon> getWagons()
        {
            return wagons;
        }

        public void sortAnimals()
        {
            wagons.Add(new Wagon());
           
            foreach (var wagon in wagons)
            {
                foreach(var animal in animals)
                {
                    if (wagon.getWagonSpace() < 10)
                    {
                        wagon.wagonAnimals.Add(animal);

                        if (wagon.getAnimalType() == "Carnivoor")
                        {
                            if (wagon.getAnimalSize() > animal.getSize() || wagon.getAnimalSize() < animal.getSize() || wagon.getAnimalSize() == animal.getSize())
                            {
                                MessageBox.Show(animal.getType());
                                wagon.wagonAnimals.Remove(animal);
                            }
                        }

                        wagon.setWagonSpace(animal.getSize());
                    }
                }
            }
        }
    }
}
