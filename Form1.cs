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
        large,
    }

    enum AnimalType
    {
        herbivore,
        carnivore
    }

    public partial class Form1 : Form
    {
        Train _train = new Train();

        public Form1()
        {
            InitializeComponent();

            animalSizeSelector.DataSource = Enum.GetValues(typeof(AnimalSize));
            setAnimalType.DataSource = Enum.GetValues(typeof(AnimalType));
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateAnimal_Click(object sender, EventArgs e)
        {
            Enum.TryParse(animalSizeSelector.SelectedValue.ToString(), out AnimalSize type);
            Enum.TryParse(setAnimalType.SelectedValue.ToString(), out AnimalType animalType);

            _train.createAnimal(type, animalType);
            animalListBox.Items.Add(setAnimalType.Text + " " + type.ToString());
        }

        private void SortAnimals_Click(object sender, EventArgs e)
        {
            _train.sortAnimals();
        }
    }
}
