using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Forma1.controller;
using Forma1.myexeption;
using Forma1.repository;

namespace Forma1
{
    public partial class Form1Form : Form
    {
        /// <summary>
        /// Ha nincs kijelölt elem térjen vissza
        /// Olvassa ki a ListBox-okból a csapatnevet és a versenyző nevet
        /// Az alsó rétegek felhasználásával keresse meg a kiolvasott adatok alapján azt a versenyzőt, amelyiket
        /// a csapat név és a versenyző név meghatároz.
        /// Ha megtalálta írja ki az adatait a versenyző megfelelő TextBoxokba
        /// ControllerException esetén logolja a hibát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxRacer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ha nincs kijelölt elem térjen vissza
            // 0-tól indexálódik
            // -1 -> kijelölt elem i
            if (listBoxRacer.SelectedIndex < 0)
            {
                return;
            }
            // LÉNYEG:
            // Olvassa ki a ListBox-okból a csapatnevet és a versenyző nevet

            string csapatneve = listBoxTeam.SelectedItem.ToString();
            string versenyzo = listBoxRacer.SelectedItem.ToString();

            // Az alsó rétegek felhasználásával keresse meg a kiolvasott adatok alapján azt a versenyzőt, amelyiket
            // a csapat név és a versenyző név meghatároz.
            Racer r = controller.searchRacerByName(csapatneve, versenyzo);

            // Ha megtalálta írja ki az adatait a versenyző megfelelő TextBoxokba
            // ControllerException esetén logolja a hibát

            //GUI -n megnézni a textbox-ok neveit, és óda kell vissza dobni az adatokat
            textBoxRacerName.Text = r.getName();
            textBoxRacerAge.Text = r.getAge().ToString();
            textBoxRacerSalary.Text = r.getSalary().ToString();

        }

        /// <summary>
        /// Törölje a hozzáadás gomb ErrorPrivert
        /// Ha nincs kijelölt csapat név térjen vissza
        /// Olvassa ki a csapat nevét, és a versenyző adatait
        /// Alsóbb rétegek segítségével adja hozzá a versenyzőt a csapathoz
        /// Törölje és frissítse a versenyzőket megjelenítő listBox-ot
        /// Ha hibát kap el hozzáadás során, jelenítse meg az error provider segítségével
        /// </summary>
        private void buttonAddRacer_Click(object sender, EventArgs e)
        {
            //11.Forma1FormRacerManagment
            //- buttonAddRacer_Click

            // Törölje a hozzáadás gomb ErrorPrivert
            errorProviderAddRacer.Clear();

            // Ha nincs kijelölt csapat név térjen vissza
            if (listBoxTeam.SelectedIndex < 0)
            {
                return;
            }

            // Olvassa ki a csapat nevét, és a versenyző adatait
            string csapatneve = listBoxTeam.SelectedItem.ToString();
            string versenyzoneve = textBoxRacerName.Text;
            string versenyzoeletkor = textBoxRacerAge.Text;
            string versenyzofizetes = textBoxRacerSalary.Text;

            // Alsóbb rétegek segítségével adja hozzá a versenyzőt a csapathoz
            try
            {
                controller.addRacerToTeam(csapatneve, versenyzoneve, versenyzoeletkor, versenyzofizetes);
            }
            catch (Exception ex)
            {
                errorProviderAddRacer.SetError(buttonAddRacer, ex.Message);
            }

            // Törölje és frissítse a versenyzőket megjelenítő listBox-ot
            listBoxRacer.DataSource = null;
            listBoxRacer.DataSource = controller.getTeamRacersName(csapatneve);

            // Ha hibát kap el hozzáadás során, jelenítse meg az error provider segítségével

        }

        /// <summary>
        /// Valósítsa meg a megfelelő error providerrel a hibák kezelését
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateRacer_Click(object sender, EventArgs e)
        {
            errorProviderUpdateRacer.Clear();

            if (listBoxTeam.SelectedIndex < 0 || listBoxRacer.SelectedIndex<0)
                return;
            string teamName = listBoxTeam.SelectedItem.ToString();
            string racerToModify = listBoxRacer.SelectedItem.ToString();
            string racerName = textBoxRacerName.Text;
            string racerAge = textBoxRacerAge.Text;
            string racerSalary = textBoxRacerSalary.Text;
            try
            {
                controller.updateRacerInTeam(teamName, racerToModify, racerName, racerAge, racerSalary);
                listBoxRacer.DataSource = null;
                listBoxRacer.DataSource = controller.getTeamRacersName(teamName);
            }
            catch (ControllerException ce)
            {
                errorProviderUpdateRacer.SetError(buttonUpdateRacer, ce.Message);
            }
        }

        private void buttonDeleteRacer_Click(object sender, EventArgs e)
        {
            errorProviderUpdateRacer.Clear();
            if (listBoxTeam.SelectedIndex < 0)
                return;
            string teamName = listBoxTeam.SelectedItem.ToString();
            string racerName = textBoxRacerName.Text;
            string racerAge = textBoxRacerAge.Text;
            try
            {
                controller.deleteRacerInTeam(teamName, racerName, racerAge);
                listBoxRacer.DataSource = null;                
                textBoxRacerName.Text = string.Empty;
                textBoxRacerAge.Text = string.Empty;
                textBoxRacerSalary.Text = string.Empty;
                List<string> racerNames= controller.getTeamRacersName(teamName);
                if (racerNames.Count > 0)
                {
                    listBoxRacer.DataSource = racerNames;
                    listBoxRacer.SelectedIndex = 0;
                }

            }
            catch (ControllerException ce)
            {
                errorProviderUpdateRacer.SetError(buttonDeleteRacer, ce.Message);
            }
        }       

        private void buttonMoveToTeam_Click(object sender, EventArgs e)
        {
            errorProviderMoveToTeam.Clear();
            if (listBoxTeam.SelectedIndex < 0)
                return;
            string fromTeamName = listBoxTeam.SelectedItem.ToString();
            if (comboBoxTeamMove.SelectedIndex < 0)
                return;
            string toTeamName = comboBoxTeamMove.SelectedItem.ToString();
            if (listBoxRacer.SelectedIndex < 0)
                return;
            string movedRacerName = listBoxRacer.SelectedItem.ToString();
            try
            {
                controller.moveToTeam(fromTeamName, toTeamName, movedRacerName);
                listBoxRacer.DataSource = null;
                listBoxRacer.DataSource = controller.getTeamRacersName(fromTeamName);
            }
            catch(ControllerException ce)
            {
                errorProviderMoveToTeam.SetError(buttonMoveToTeam, ce.Message);
            }
        }
    }
}
