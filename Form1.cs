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
        App application = new App();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateAnimal_Click(object sender, EventArgs e)
        {
            application.createAnimal(5, "carnivoor");
        }
    }
}
