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

namespace IskolaProjekt
{
    public partial class IskolaForm : Form
    {
        private IskolaVezerlo vezerlo;

        public IskolaForm()
        {
            InitializeComponent();
            vezerlo = new IskolaVezerlo();
        }

        private void buttonInitializeData_Click(object sender, EventArgs e)
        {
            vezerlo.betoltTesztAdatokat();
            listBoxOsztalyok.DataSource = vezerlo.getOsztalyAzonosito();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMeghatarozIskolaAtlag_Click(object sender, EventArgs e)
        {
        }
    }
}
