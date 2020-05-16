using IskolaProjekt.myexeption;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IskolaProjekt
{
    public partial class IskolaForm : Form
    {
        private void listBoxOsztalyok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOsztalyok.SelectedIndex < 0)
            {
                textBoxUjOsztalyAzonosito.Text = string.Empty;
                comboBoxMelyikOsztalybaHelyezzukAt.DataSource = null;
                return;
            }

            string osztalyAzonosito = listBoxOsztalyok.SelectedItem.ToString();
            List<string> diakNevek = vezerlo.megahtarozOsztalyDiakjainakNevet(osztalyAzonosito);
            if (diakNevek == null)
                return;
            listBoxDiakok.DataSource = diakNevek;
            if (diakNevek.Count > 0)
            {
                textBoxUjOsztalyAzonosito.Text = osztalyAzonosito;
                comboBoxMelyikOsztalybaHelyezzukAt.DataSource = vezerlo.getOsztalyAzonositokKihagyva(osztalyAzonosito);
            }
            else
            {
                textBoxUjOsztalyAzonosito.Text = string.Empty;
                comboBoxMelyikOsztalybaHelyezzukAt.DataSource = null;
            }
        }

        private void buttonHozzadOsztalyt_Click(object sender, EventArgs e)
        {
        }

        private void buttonModositOsztalyt_Click(object sender, EventArgs e)
        {
            errorProviderModositOsztalyt.Clear();

            if (listBoxOsztalyok.SelectedIndex < 0)
            {
                return;
            }

            try
            {
                string ujOsztalyAzonosito = textBoxUjOsztalyAzonosito.Text;
                string regiOsztalyAzonosito = listBoxOsztalyok.SelectedItem.ToString();
                vezerlo.modositOsztalyAzonositot(regiOsztalyAzonosito, ujOsztalyAzonosito);
                listBoxOsztalyok.DataSource = null;
                listBoxOsztalyok.DataSource = vezerlo.getOsztalyAzonosito();
            }
            catch (ControllerException ce)
            {
                errorProviderModositOsztalyt.SetError(buttonModositOsztalyt, ce.Message);
            }
        }

        private void buttonTorolOsztalyt_Click(object sender, EventArgs e)
        {
            errorProviderTorolOsztalyt.Clear();

            if (listBoxOsztalyok.SelectedIndex < 0)
            {
                return;
            }


            try
            {
                string torlendoOsztalyAzonosito = listBoxOsztalyok.SelectedItem.ToString();
                vezerlo.torolOsztalyt(torlendoOsztalyAzonosito);
                listBoxOsztalyok.DataSource = null;
                listBoxOsztalyok.DataSource = vezerlo.getOsztalyAzonosito();
                if (listBoxOsztalyok.SelectedIndex >= 0)
                {
                    string kihagyandoOsztalyAzonosito = listBoxOsztalyok.SelectedItem.ToString();
                    List<string> osztalyokKihagyvaKivalasztott =
                        vezerlo.getOsztalyAzonositokKihagyva(kihagyandoOsztalyAzonosito);
                    if (osztalyokKihagyvaKivalasztott.Count > 0)
                        comboBoxMelyikOsztalybaHelyezzukAt.DataSource = osztalyokKihagyvaKivalasztott;
                    else
                        comboBoxMelyikOsztalybaHelyezzukAt.Text = string.Empty;
                }
                else
                    comboBoxMelyikOsztalybaHelyezzukAt.Text = string.Empty;
            }
            catch (ControllerException ce)
            {
                errorProviderModositOsztalyt.SetError(buttonTorolOsztalyt, ce.Message);
            }
        }

        private void buttonSzamolOsztalyAtlag_Click(object sender, EventArgs e)
        {
            // osztály átlag ...
        }
    }
}
