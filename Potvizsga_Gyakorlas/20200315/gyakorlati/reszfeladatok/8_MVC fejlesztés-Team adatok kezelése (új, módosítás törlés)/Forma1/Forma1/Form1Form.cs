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
            Racer selectedRacer = controller.searchRacerByName(teamName, racerName);
            textBoxRacerName.Text = selectedRacer.getName();
            textBoxRacerAge.Text = selectedRacer.getAge().ToString();
            textBoxRacerSalary.Text = selectedRacer.getSalary().ToString();
        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            string csapathozzaad = textBoxTeamName.Text;

            try
            {
                controller.hozzadcsapat(csapathozzaad);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            listBoxTeam.DataSource = controller.getTeamNames();
        }

        private void buttonDeleteTeam_Click(object sender, EventArgs e)
        {
            if (listBoxTeam.SelectedIndex < 0)
            {
                return;
            }

            string torlendoCsapatNeve = ""; torlendoCsapatNeve = listBoxTeam.SelectedItem.ToString();


            controller.CsapatTorles(torlendoCsapatNeve); //Itt tudom megadni annak a csapat nevét,

            listBoxTeam.DataSource = null;
            listBoxTeam.DataSource = controller.getTeamNames();
        }

        private void ButtonUpdateTeam_Click(object sender, EventArgs e)
        {
            // A "listBoxTeam" ből veszük ki az éppen aktuális kijelölt elemet. A "selectedItem"- értékét object típusban kapom meg, és ezt átkell konvertálni ToString típusuvá.
            string modositandoCsapatnev = listBoxTeam.SelectedItem.ToString();

            //A "textBoxTeamName" -ből a "text" tújajdonságát szedjük ki.
            string ujCsapatNeve = textBoxTeamName.Text;

            //Dobájluk levelé a paramétereket az üzleti logikához. A "modositCsapatnev" függvényt nevét mi adjuk meg, és a paramétereket is megkell adni.
            controller.modositCsapatnev(modositandoCsapatnev, ujCsapatNeve);

            listBoxTeam.DataSource = null; //A megjelenő adatokat "null"-ázuk.
            listBoxTeam.DataSource = controller.getTeamNames(); //Az adatokat újra lekérdezzük.
        }
    }
}
