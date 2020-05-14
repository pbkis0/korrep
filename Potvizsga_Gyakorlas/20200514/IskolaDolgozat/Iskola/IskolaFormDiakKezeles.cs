using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IskolaProjekt.controller;
using IskolaProjekt.myexeption;
using IskolaProjekt.repository;

namespace IskolaProjekt
{
    public partial class IskolaForm : Form
    {

        private void listBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDiakok.SelectedIndex < 0)               
                return;
            string osztalyAzonosito = listBoxOsztalyok.SelectedItem.ToString();
            string diakNev = listBoxDiakok.SelectedItem.ToString();
            try
            {
                Diak kivalasztotDiak = vezerlo.keresDiakotOsztalyban(osztalyAzonosito, diakNev);
                if (kivalasztotDiak != null)
                {
                    textBoxDiakNev.Text = kivalasztotDiak.getNev();
                    textBoxDiakEletkor.Text = kivalasztotDiak.getEletkor().ToString();
                    textBoxDiakAtlag.Text = kivalasztotDiak.getAtlag().ToString();
                }
            }
            catch (ControllerException ce)
            {
            }
        }

        private void buttonDiakHozzaadasa_Click(object sender, EventArgs e)
        {
            errorProviderDiakHozzaadasa.Clear();
            if (listBoxOsztalyok.SelectedIndex < 0)
                return;
            string osztalyAzonosoto = listBoxOsztalyok.SelectedItem.ToString();
            string diakNeve = textBoxDiakNev.Text;
            string diakEletkora = textBoxDiakEletkor.Text;
            string diakAtlaga = textBoxDiakAtlag.Text;
            try
            {
                vezerlo.hozzaadDiakotOsztalyhoz(osztalyAzonosoto, diakNeve, diakEletkora, diakAtlaga);
                listBoxDiakok.DataSource = null;
                listBoxDiakok.DataSource = vezerlo.megahtarozOsztalyDiakjainakNevet(osztalyAzonosoto);
            }
            catch (ControllerException ce)
            {
                errorProviderDiakHozzaadasa.SetError(buttonHozzadDiak, ce.Message);
            }
        }

        private void buttonModositDiak_Click(object sender, EventArgs e)
        {
            errorProviderModositDiak.Clear();
            if (listBoxOsztalyok.SelectedIndex < 0 || listBoxDiakok.SelectedIndex<0)
                return;
            string osztalyAzonosito = listBoxOsztalyok.SelectedItem.ToString();
            string modositandoDiakNeve = listBoxDiakok.SelectedItem.ToString();
            string diakNeve = textBoxDiakNev.Text;
            string diakEletkora = textBoxDiakEletkor.Text;
            string diakAtlaga = textBoxDiakAtlag.Text;
            try
            {
                vezerlo.modositDiakotOsztalyba(osztalyAzonosito, modositandoDiakNeve, diakNeve, diakEletkora, diakAtlaga);
                listBoxDiakok.DataSource = null;
                listBoxDiakok.DataSource = vezerlo.megahtarozOsztalyDiakjainakNevet(osztalyAzonosito);
            }
            catch (ControllerException ce)
            {
                errorProviderModositDiak.SetError(buttonModositDiak, ce.Message);
            }
        }

        private void buttonTorolDiak_Click(object sender, EventArgs e)
        {
            errorProviderModositDiak.Clear();
            if (listBoxOsztalyok.SelectedIndex < 0)
                return;
            string osztalyAzonosito = listBoxOsztalyok.SelectedItem.ToString();
            string diakNeve = textBoxDiakNev.Text;
            string diakEletkora = textBoxDiakEletkor.Text;
            try
            {
                vezerlo.torolAdottOsztalybolAdottDiakot(osztalyAzonosito, diakNeve, diakEletkora);
                listBoxDiakok.DataSource = null;                
                textBoxDiakNev.Text = string.Empty;
                textBoxDiakEletkor.Text = string.Empty;
                textBoxDiakAtlag.Text = string.Empty;
                List<string> diakNevek= vezerlo.megahtarozOsztalyDiakjainakNevet(osztalyAzonosito);
                if (diakNevek.Count > 0)
                {
                    listBoxDiakok.DataSource = diakNevek;
                    listBoxDiakok.SelectedIndex = 0;
                }

            }
            catch (ControllerException ce)
            {
                errorProviderModositDiak.SetError(buttonTorolDiakot, ce.Message);
            }
        }

        private void buttonSzamolOsztalyAtlag(object sender, EventArgs e)
        {
            if (listBoxOsztalyok.SelectedIndex < 0)
                return;
            string osztalyAzonosito = listBoxOsztalyok.SelectedItem.ToString();
        }

        private void buttonAthelyezDiakotMasikOsztalyba_Click(object sender, EventArgs e)
        {
            errorProvideAthelyezDiakotMasikOsztalyba.Clear();
            if (listBoxOsztalyok.SelectedIndex < 0)
                return;
            string osztalyAzonositoMelyikbol = listBoxOsztalyok.SelectedItem.ToString();
            if (comboBoxMelyikOsztalybaHelyezzukAt.SelectedIndex < 0)
                return;
            string osztalyAzonositoMelyikbe = comboBoxMelyikOsztalybaHelyezzukAt.SelectedItem.ToString();
            if (listBoxDiakok.SelectedIndex < 0)
                return;
            string athelyezendoDiakNev = listBoxDiakok.SelectedItem.ToString();
            try
            {
                vezerlo.athelyezDiakotOsztalyba(osztalyAzonositoMelyikbol, osztalyAzonositoMelyikbe, athelyezendoDiakNev);
                listBoxDiakok.DataSource = null;
                listBoxDiakok.DataSource = vezerlo.megahtarozOsztalyDiakjainakNevet(osztalyAzonositoMelyikbol);
            }
            catch(ControllerException ce)
            {
                errorProvideAthelyezDiakotMasikOsztalyba.SetError(buttonAthelyezDiakotMasikOsztalyba, ce.Message);
            }
        }
    }
}
