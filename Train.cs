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

        public void CreateAnimal(AnimalSize size, AnimalType type) {
            animalsToSort.Add(new Animal(size, type));
        }

        public List<Wagon> GetWagons()
        {
            return wagons;
        }

        public void SortAnimals()
        {
            var newWagon = new Wagon();

            foreach (var animalToAdd in animalsToSort)
            {
                if (newWagon.Calculate(animalToAdd) == true)
                {
                    newWagon.AddAnimal(animalToAdd);
                }
                else
                {
                    newWagon = new Wagon();
                    newWagon.AddAnimal(animalToAdd);
                    wagons.Add(newWagon);

                }
            }
            wagons.Add(newWagon);

            MessageBox.Show(wagons.Count().ToString());
        }
    }
}
