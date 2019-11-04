using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circustTrein
{
    class Animal
    {
        public AnimalSize Size { get; private set; }
        public string type { get; private set; }
        public bool isInWagon { get; private set; }
        public int points { get; private set; }
        
        public Animal(AnimalSize size, string animalType) {
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

            this.type = animalType;
        }

        public bool getIfAnimalInWagon()
        {
            return isInWagon;
        }

        public void setIsInWagon()
        {
            isInWagon = true;
        }

    }
}
