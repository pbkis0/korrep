using System;
using MVC.Controller;
using System.Windows.Forms;

namespace MVC.View
{
    public partial class FormModal : Form
    {
        private BeerController controller;

        public FormModal()
        {
            InitializeComponent();
            controller = new BeerController(true);
        }

        private void FormModal_Load(object sender, EventArgs e)
        {
            textBoxID.Text = controller.GetNextID();
            comboBoxManufacturer.DataSource = controller.GetManufacturerNames();
        }
    }
}
