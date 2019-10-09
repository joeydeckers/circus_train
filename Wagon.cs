﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circustTrein
{
    class Wagon
    {
        private int size = 10;
        private int space = 0;
        private bool isFull = false;

        public List<Animal> wagonAnimals = new List<Animal>();
        public int getWagonSpace()
        {
            return space;
        }

        public void addAnimal(Animal animalToAdd) {

            wagonAnimals.Add(animalToAdd);
            space += animalToAdd.getSize();

            if (space == 10) {
                isFull = true;
            }
        }
    }


}
