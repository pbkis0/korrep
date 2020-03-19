using Forma1.Controller;
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

        // 1) listBoxTeam -> 2*click -> legenerálja a "ListBoxTeam_SelectedIndexChanged" eseményt, a Form1Form.cs fileba (code-behind).
        private void ListBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 2) Selected index changed esemény hatására minden egyes ilyen műveletnél (nyomkodom a nyilakat, listbox indexe változik
            // kinyerem egy teamName (string) változóba hogy a listboxban adott kijelölt
            // indexen milyen érték szerepel(McLaren, Renault)
            string teamName = listBoxTeam.SelectedItem.ToString();

            // 3) ListBoxRacerbe (atól függően, hogy melyik csapat van kijelölve a ListBoxTeamben: milyen érték van kinyerve a teamName-be)
            // először null-ra kötöm a listBoxRacer-t utána kötöm bele az adott csapat versenyzőit

            listBoxRacer.DataSource = null;

            // 4) controllerbe hívok egy getRacerNames(CSAPATNÉV PARAMÉTERÜL, AMIT KISZEDTEM) metódust -
            // ezt már lehet kötni a listBoxRacer-be (miután lenulloltam)
            // elugrik a controllerbe a szekvenciális végrehajtás: (F12-vel tudsz beleugrani)
            listBoxRacer.DataSource = controller.getRacerNames(teamName);

            //16) KÉSZ!
        }
    }
}
