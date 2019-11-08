using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustTrein
{
    public class Animal
    {
        public AnimalSize Size { get; private set; }
        public AnimalType Type { get; private set; }
        public bool isInWagon { get;  set; }
        public int points { get; private set; }
        
        public Animal(AnimalSize size, AnimalType animalType) {
            isInWagon = false;
            switch(size)
            {
                case AnimalSize.small:
                    points = 1;
                    break;
                case AnimalSize.medium:
                    points = 3;
                    break;
                case AnimalSize.large:
                    points = 5;
                    break;
            }

            Type = animalType;

        }

    }
}
