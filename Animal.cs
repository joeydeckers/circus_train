using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustTrein
{
    class Animal
    {
        private int size;
        private string type;
        private bool isInWagon = false;
        public Animal(int size, string type) {
            this.size = size;
            this.type = type;
        }

        public bool getIfAnimalInWagon()
        {
            return isInWagon;
        }

        public void setIsInWagon()
        {
            isInWagon = true;
        }


        public int getSize()
        {
            return size;
        }

        public string getType() {
            return type;
        }
    }
}
