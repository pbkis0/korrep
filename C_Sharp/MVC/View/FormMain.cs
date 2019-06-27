using System;
using MVC.exceptions;
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
            comboBoxManufacturer.DataSource = controller.GetManufacturerNames();
            comboBoxAlcohol.DataSource = controller.GetAlcohol();
        }

        private void ButtonFilterManufacturer_Click(object sender, EventArgs e)
        {
            string manufacturer = comboBoxManufacturer.SelectedItem.ToString();


            listBoxData.DataSource = null;
            listBoxData.DataSource = controller.FilterManufacturer(manufacturer);
        }

        private void ButtonFilterAlcohol_Click(object sender, EventArgs e)
        {
            string alcohol = comboBoxAlcohol.SelectedItem.ToString();

            listBoxData.DataSource = null;
            listBoxData.DataSource = controller.FilterAlcohol(alcohol);
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            FormModal formModal = new FormModal();
            //formModal.Show(); // Nem-modális megjelenített: ki lehet kattintani a felugró ablakból
            formModal.ShowDialog(); // modálisan megjelenített: nem kattinthatsz ki ebből az aktív ablakból
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxData.SelectedIndex;

            try
            {
                controller.Delete(index); //back-end oldalon törlünk index alapján objektumot
            }
            catch (DeleteException ex)
            {
                errorProviderTorlesHiba.SetError(buttonDelete, ex.Message);
            }

            listBoxData.DataSource = null;
            listBoxData.DataSource = controller.GetBeers();
        }

        private void ButtonFileWriter_Click(object sender, EventArgs e)
        {
            controller.fajlbaIras();
        }
    }
}
