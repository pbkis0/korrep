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

        private void listBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Nincs kijelölve csapat
            if (listBoxTeam.SelectedIndex < 0)
                return;
            //olvassuk a kijelölt csapat nevét
            string teamName = listBoxTeam.SelectedItem.ToString();
            //a csapat neve jelenjen meg a TextBox-ban
            textBoxTeamName.Text = teamName;
            //MVC fejlesztés
            //listBoxRacerbe->kiválasztott csapat versenyzőinek neve
            listBoxRacer.DataSource = controller.getRacerNames(teamName);
        }

        private void buttonComputeTeamSalary_Click(object sender, EventArgs e)
        {
            string teamName = listBoxTeam.SelectedItem.ToString(); // Listboxból kiszedtem kinek a fizetésére vagyok kíváncsi
            textBoxTeamSalary.Text = controller.getTeamSalary(teamName).ToString(); //fizetés textboxba beleköti azt a függvényt ami meghatározza (GUI->Controller) int->toString()
        }

        private void buttonComputeF1Salary_Click(object sender, EventArgs e)
        {
            textBoxF1Salary.Text = controller.getF1Salary().ToString();
        }
    }
}
