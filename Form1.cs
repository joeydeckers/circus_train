using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circustTrein
{
    enum AnimalSize
    {
        small,
        medium,
        large
    }

    public partial class Form1 : Form
    {
        Train _train = new Train();

   

        public Form1()
        {
            InitializeComponent();

            animalSizeSelector.Items.Add(AnimalSize.small);
            animalSizeSelector.Items.Add(AnimalSize.medium);
            animalSizeSelector.Items.Add(AnimalSize.large);

            setAnimalType.Items.Add("Carnivoor");
            setAnimalType.Items.Add("Herbivoor");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateAnimal_Click(object sender, EventArgs e)
        {
            Enum.TryParse(animalSizeSelector.ToString(), out AnimalSize type);
            string wat = setAnimalType.Text;

            _train.createAnimal(type, wat);
            animalListBox.Items.Add(setAnimalType.Text + " " + animalSizeSelector.Text);
        }

        private void SortAnimals_Click(object sender, EventArgs e)
        {
            _train.sortAnimals();
        }
    }
}
