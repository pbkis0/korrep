using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC.Controller;

namespace MVC.View
{
    public partial class FormMain : Form
    {
        private BeerController controller;

        public FormMain()
        {
            InitializeComponent();
            controller = new BeerController();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            listBoxData.DataSource = controller.GetBeers();
            comboBoxManufacturer.DataSource = controller.GetManufacturers();
            comboBoxAlcohol.DataSource = controller.GetAlcohol();
        }

        private void ButtonFilterManufacturer_Click(object sender, EventArgs e)
        {

        }

        private void ButtonFilterAlcohol_Click(object sender, EventArgs e)
        {

        }
    }
}
