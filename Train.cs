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
            wagons.Add(newWagon);
            foreach (var animalToAdd in animalsToSort)
            {

                // for loop maken die kijkt naar de indivuele/alle wagon en structuur moet anders

                for(int i = 0; i < wagons.Count(); i++)
                {
                    if (!wagons[i].Calculate(animalToAdd))
                    {
                        MessageBox.Show(i.ToString());
                        //MessageBox.Show(newWagon.GetAnimals().ToString());
                        //newWagon.AddAnimal(animalToAdd);
                        newWagon = new Wagon();
                        newWagon.AddAnimal(animalToAdd);
                        wagons.Add(newWagon);
                        break;
                    }
                }
            }
           
        }
    }
}
