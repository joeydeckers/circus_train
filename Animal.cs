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
        public Animal(int size, string type) {
            this.size = size;
            this.type = type;
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
