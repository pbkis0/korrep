using Forma1.Controller;
using Forma1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma1
{
    public partial class Form1Form : Form
    {
        F1Controller controller;
        public Form1Form()
        {
            controller = new F1Controller();
            InitializeComponent();
        }

        private void buttonInitializeData_Click(object sender, EventArgs e)
        {
            controller.provideTestData();
            listBoxTeam.DataSource = controller.getTeamNames();
        }

        private void listBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTeam.SelectedIndex < 0)
                return;
            string teamName = listBoxTeam.SelectedItem.ToString();
            textBoxTeamName.Text = teamName;
            listBoxRacer.DataSource = controller.getRacerNames(teamName);
        }

        private void listBoxRacer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTeam.SelectedIndex < 0 || listBoxRacer.SelectedIndex < 0)
                return;

            string teamName = listBoxTeam.SelectedItem.ToString();
            string racerName = listBoxRacer.SelectedItem.ToString();

            Racer r = controller.searchRacerByName(teamName, racerName); // Racer r = null;

            textBoxRacerName.Text = r.getName();
            textBoxRacerAge.Text = r.getAge().ToString();
            textBoxRacerSalary.Text = r.getSalary().ToString();
        }

        private void ButtonAddRacer_Click(object sender, EventArgs e)
        {
            // Ki kell szedni az adatokat a GUI-ból: versenyzők adatai
            string racerName = textBoxRacerName.Text;
            string racerAge = textBoxRacerAge.Text;
            string racerSalary = textBoxRacerSalary.Text;

            string teamName = listBoxTeam.SelectedItem.ToString(); // csapat neve: versenyzőt melyik csapathoz adjuk hozzá?

            controller.addRacer(racerName, racerAge, racerSalary, teamName);

            // ------------------ EDDIG BACK-END MEMÓRIÁHOZ HOZZÁADÁS

            listBoxRacer.DataSource = null;
            listBoxRacer.DataSource = controller.getRacerNames(teamName);
        }

        private void ButtonUpdateRacer_Click(object sender, EventArgs e)
        {
            // Ki kell szedni az adatokat a GUI-ból: versenyzők adatai

            string racerNameToModify = listBoxRacer.SelectedItem.ToString(); //MÓDOSÍTANDÓ NÉV ALAPJÁN TÖRTÉNŐ SZŰRÉS
            string racerName = textBoxRacerName.Text; // MÓDOSÍTOTT NÉV
            string racerAge = textBoxRacerAge.Text;
            string racerSalary = textBoxRacerSalary.Text;

            string teamName = listBoxTeam.SelectedItem.ToString(); // csapat neve: versenyzőt melyik csapatban módosítunk?

            controller.updateRacer(racerNameToModify, racerName, racerAge, racerSalary, teamName);

            // ------------------ EDDIG BACK-END MEMÓRIÁHOZ MÓDOSÍTÁS

            listBoxRacer.DataSource = null;
            listBoxRacer.DataSource = controller.getRacerNames(teamName);
        }

        private void ButtonDeleteRacer_Click(object sender, EventArgs e)
        {
            string racerName = textBoxRacerName.Text;
            string teamName = listBoxTeam.SelectedItem.ToString(); // csapat neve: versenyzőt melyik csapatban módosítunk?


            controller.deleteRacer(racerName, teamName);

            // ------------------ EDDIG BACK-END MEMÓRIÁHOZ TÖRLÉS

            listBoxRacer.DataSource = null;
            listBoxRacer.DataSource = controller.getRacerNames(teamName);
        }
    }
}
