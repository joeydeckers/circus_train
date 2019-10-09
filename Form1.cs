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
    public partial class Form1 : Form
    {
        Train _train = new Train();

        public Form1()
        {
            InitializeComponent();
            animalSizeSelector.Items.Add(1);
            animalSizeSelector.Items.Add(3);
            animalSizeSelector.Items.Add(5);

            setAnimalType.Items.Add("Carnivoor");
            setAnimalType.Items.Add("Herbivoor");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateAnimal_Click(object sender, EventArgs e)
        {
            _train.createAnimal(Convert.ToInt32(animalSizeSelector.Text), setAnimalType.Text);
            animalListBox.Items.Add(setAnimalType.Text + " " + animalSizeSelector.Text);
        }

        private void SortAnimals_Click(object sender, EventArgs e)
        {
            _train.sortAnimals();
        }
    }
}
