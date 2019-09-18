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
        public void createAnimal(int size, string type) {
            Animal animal = new Animal(size, type);
            MessageBox.Show(animal.getType());
        }
    }
}
