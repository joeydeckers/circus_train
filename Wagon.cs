using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustTrein
{
    class Wagon
    {
        private int size = 10;
        private int space = 0;
        public List<Animal> wagonAnimals = new List<Animal>();
        public int getWagonSpace()
        {
            return space;
        }

        public string getAnimalType()
        {
            string animalType = "";
            foreach(var animal in wagonAnimals)
            {
                return animal.getType();
            }
            return animalType;
        }

        public int getAnimalSize()
        {
            int animalSize = 0;

            foreach (var animal in wagonAnimals)
            {
                return animal.getSize();
            }

            return animalSize;
        }

        public void setWagonSpace(int takenSpace)
        {
            space += takenSpace;
        }
    }


}
