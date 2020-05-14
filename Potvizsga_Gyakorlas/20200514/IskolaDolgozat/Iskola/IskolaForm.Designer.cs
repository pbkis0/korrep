namespace IskolaProjekt
{
    partial class IskolaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonTesztadatokBetoltese = new System.Windows.Forms.Button();
            this.buttonTorolOsztalyt = new System.Windows.Forms.Button();
            this.buttonModositOsztalyt = new System.Windows.Forms.Button();
            this.buttonHozzadOsztalyt = new System.Windows.Forms.Button();
            this.labelOsztalyNeve = new System.Windows.Forms.Label();
            this.textBoxUjOsztalyAzonosito = new System.Windows.Forms.TextBox();
            this.labelOsztalyok = new System.Windows.Forms.Label();
            this.listBoxOsztalyok = new System.Windows.Forms.ListBox();
            this.buttonTorolDiakot = new System.Windows.Forms.Button();
            this.buttonModositDiak = new System.Windows.Forms.Button();
            this.buttonHozzadDiak = new System.Windows.Forms.Button();
            this.labelDiakok = new System.Windows.Forms.Label();
            this.listBoxDiakok = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxDiakAtlag = new System.Windows.Forms.TextBox();
            this.textBoxDiakEletkor = new System.Windows.Forms.TextBox();
            this.textBoxDiakNev = new System.Windows.Forms.TextBox();
            this.labelDiakAtlag = new System.Windows.Forms.Label();
            this.labelDiakEletkor = new System.Windows.Forms.Label();
            this.labelDiakNev = new System.Windows.Forms.Label();
            this.comboBoxMelyikOsztalybaHelyezzukAt = new System.Windows.Forms.ComboBox();
            this.buttonKilepes = new System.Windows.Forms.Button();
            this.buttonMeghatarozOsztalyAtlag = new System.Windows.Forms.Button();
            this.textBoxOsztalyAtlag = new System.Windows.Forms.TextBox();
            this.buttonMeghatarozIskolaAtlag = new System.Windows.Forms.Button();
            this.textBoxIskolaAtlag = new System.Windows.Forms.TextBox();
            this.errorProviderHozzadOsztalyt = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderModositOsztalyt = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTorolOsztalyt = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDiakHozzaadasa = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderModositDiak = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTorolVersenyzo = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonAthelyezDiakotMasikOsztalyba = new System.Windows.Forms.Button();
            this.errorProvideAthelyezDiakotMasikOsztalyba = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHozzadOsztalyt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModositOsztalyt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTorolOsztalyt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDiakHozzaadasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModositDiak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTorolVersenyzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvideAthelyezDiakotMasikOsztalyba)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTesztadatokBetoltese
            // 
            this.buttonTesztadatokBetoltese.Location = new System.Drawing.Point(12, 22);
            this.buttonTesztadatokBetoltese.Name = "buttonTesztadatokBetoltese";
            this.buttonTesztadatokBetoltese.Size = new System.Drawing.Size(180, 23);
            this.buttonTesztadatokBetoltese.TabIndex = 15;
            this.buttonTesztadatokBetoltese.Text = "Teszt adatok betöltése";
            this.buttonTesztadatokBetoltese.UseVisualStyleBackColor = true;
            this.buttonTesztadatokBetoltese.Click += new System.EventHandler(this.buttonInitializeData_Click);
            // 
            // buttonTorolOsztalyt
            // 
            this.buttonTorolOsztalyt.Location = new System.Drawing.Point(37, 564);
            this.buttonTorolOsztalyt.Name = "buttonTorolOsztalyt";
            this.buttonTorolOsztalyt.Size = new System.Drawing.Size(75, 23);
            this.buttonTorolOsztalyt.TabIndex = 14;
            this.buttonTorolOsztalyt.Text = "Töröl";
            this.buttonTorolOsztalyt.UseVisualStyleBackColor = true;
            this.buttonTorolOsztalyt.Click += new System.EventHandler(this.buttonTorolOsztalyt_Click);
            // 
            // buttonModositOsztalyt
            // 
            this.buttonModositOsztalyt.Location = new System.Drawing.Point(37, 535);
            this.buttonModositOsztalyt.Name = "buttonModositOsztalyt";
            this.buttonModositOsztalyt.Size = new System.Drawing.Size(75, 23);
            this.buttonModositOsztalyt.TabIndex = 13;
            this.buttonModositOsztalyt.Text = "Módosít";
            this.buttonModositOsztalyt.UseVisualStyleBackColor = true;
            this.buttonModositOsztalyt.Click += new System.EventHandler(this.buttonModositOsztalyt_Click);
            // 
            // buttonHozzadOsztalyt
            // 
            this.buttonHozzadOsztalyt.Location = new System.Drawing.Point(37, 506);
            this.buttonHozzadOsztalyt.Name = "buttonHozzadOsztalyt";
            this.buttonHozzadOsztalyt.Size = new System.Drawing.Size(75, 23);
            this.buttonHozzadOsztalyt.TabIndex = 12;
            this.buttonHozzadOsztalyt.Text = "Hozzáad";
            this.buttonHozzadOsztalyt.UseVisualStyleBackColor = true;
            this.buttonHozzadOsztalyt.Click += new System.EventHandler(this.buttonHozzadOsztalyt_Click);
            // 
            // labelOsztalyNeve
            // 
            this.labelOsztalyNeve.AutoSize = true;
            this.labelOsztalyNeve.Location = new System.Drawing.Point(34, 442);
            this.labelOsztalyNeve.Name = "labelOsztalyNeve";
            this.labelOsztalyNeve.Size = new System.Drawing.Size(70, 13);
            this.labelOsztalyNeve.TabIndex = 11;
            this.labelOsztalyNeve.Text = "Csapat neve:";
            // 
            // textBoxUjOsztalyAzonosito
            // 
            this.textBoxUjOsztalyAzonosito.Location = new System.Drawing.Point(37, 458);
            this.textBoxUjOsztalyAzonosito.Name = "textBoxUjOsztalyAzonosito";
            this.textBoxUjOsztalyAzonosito.Size = new System.Drawing.Size(155, 20);
            this.textBoxUjOsztalyAzonosito.TabIndex = 10;
            // 
            // labelOsztalyok
            // 
            this.labelOsztalyok.AutoSize = true;
            this.labelOsztalyok.Location = new System.Drawing.Point(34, 59);
            this.labelOsztalyok.Name = "labelOsztalyok";
            this.labelOsztalyok.Size = new System.Drawing.Size(98, 13);
            this.labelOsztalyok.TabIndex = 9;
            this.labelOsztalyok.Text = "Forma 1. csapatok:";
            // 
            // listBoxOsztalyok
            // 
            this.listBoxOsztalyok.FormattingEnabled = true;
            this.listBoxOsztalyok.Location = new System.Drawing.Point(37, 87);
            this.listBoxOsztalyok.Name = "listBoxOsztalyok";
            this.listBoxOsztalyok.Size = new System.Drawing.Size(155, 329);
            this.listBoxOsztalyok.TabIndex = 8;
            this.listBoxOsztalyok.SelectedIndexChanged += new System.EventHandler(this.listBoxOsztalyok_SelectedIndexChanged);
            // 
            // buttonTorolDiakot
            // 
            this.buttonTorolDiakot.Location = new System.Drawing.Point(224, 178);
            this.buttonTorolDiakot.Name = "buttonTorolDiakot";
            this.buttonTorolDiakot.Size = new System.Drawing.Size(75, 23);
            this.buttonTorolDiakot.TabIndex = 22;
            this.buttonTorolDiakot.Text = "Töröl";
            this.buttonTorolDiakot.UseVisualStyleBackColor = true;
            this.buttonTorolDiakot.Click += new System.EventHandler(this.buttonTorolDiak_Click);
            // 
            // buttonModositDiak
            // 
            this.buttonModositDiak.Location = new System.Drawing.Point(122, 178);
            this.buttonModositDiak.Name = "buttonModositDiak";
            this.buttonModositDiak.Size = new System.Drawing.Size(75, 23);
            this.buttonModositDiak.TabIndex = 21;
            this.buttonModositDiak.Text = "Módosít";
            this.buttonModositDiak.UseVisualStyleBackColor = true;
            this.buttonModositDiak.Click += new System.EventHandler(this.buttonModositDiak_Click);
            // 
            // buttonHozzadDiak
            // 
            this.buttonHozzadDiak.Location = new System.Drawing.Point(18, 178);
            this.buttonHozzadDiak.Name = "buttonHozzadDiak";
            this.buttonHozzadDiak.Size = new System.Drawing.Size(75, 23);
            this.buttonHozzadDiak.TabIndex = 20;
            this.buttonHozzadDiak.Text = "Hozzáad";
            this.buttonHozzadDiak.UseVisualStyleBackColor = true;
            this.buttonHozzadDiak.Click += new System.EventHandler(this.buttonDiakHozzaadasa_Click);
            // 
            // labelDiakok
            // 
            this.labelDiakok.AutoSize = true;
            this.labelDiakok.Location = new System.Drawing.Point(264, 59);
            this.labelDiakok.Name = "labelDiakok";
            this.labelDiakok.Size = new System.Drawing.Size(114, 13);
            this.labelDiakok.TabIndex = 17;
            this.labelDiakok.Text = "Forma 1. csapat tagjai:";
            // 
            // listBoxDiakok
            // 
            this.listBoxDiakok.FormattingEnabled = true;
            this.listBoxDiakok.Location = new System.Drawing.Point(267, 87);
            this.listBoxDiakok.Name = "listBoxDiakok";
            this.listBoxDiakok.Size = new System.Drawing.Size(297, 329);
            this.listBoxDiakok.TabIndex = 16;
            this.listBoxDiakok.SelectedIndexChanged += new System.EventHandler(this.listBoxStudent_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxDiakAtlag);
            this.panel1.Controls.Add(this.textBoxDiakEletkor);
            this.panel1.Controls.Add(this.textBoxDiakNev);
            this.panel1.Controls.Add(this.labelDiakAtlag);
            this.panel1.Controls.Add(this.labelDiakEletkor);
            this.panel1.Controls.Add(this.labelDiakNev);
            this.panel1.Controls.Add(this.buttonTorolDiakot);
            this.panel1.Controls.Add(this.buttonHozzadDiak);
            this.panel1.Controls.Add(this.buttonModositDiak);
            this.panel1.Location = new System.Drawing.Point(609, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 240);
            this.panel1.TabIndex = 23;
            // 
            // textBoxDiakAtlag
            // 
            this.textBoxDiakAtlag.Location = new System.Drawing.Point(86, 96);
            this.textBoxDiakAtlag.Name = "textBoxDiakAtlag";
            this.textBoxDiakAtlag.Size = new System.Drawing.Size(235, 20);
            this.textBoxDiakAtlag.TabIndex = 28;
            // 
            // textBoxDiakEletkor
            // 
            this.textBoxDiakEletkor.Location = new System.Drawing.Point(86, 52);
            this.textBoxDiakEletkor.Name = "textBoxDiakEletkor";
            this.textBoxDiakEletkor.Size = new System.Drawing.Size(235, 20);
            this.textBoxDiakEletkor.TabIndex = 27;
            // 
            // textBoxDiakNev
            // 
            this.textBoxDiakNev.Location = new System.Drawing.Point(51, 16);
            this.textBoxDiakNev.Name = "textBoxDiakNev";
            this.textBoxDiakNev.Size = new System.Drawing.Size(270, 20);
            this.textBoxDiakNev.TabIndex = 26;
            // 
            // labelDiakAtlag
            // 
            this.labelDiakAtlag.AutoSize = true;
            this.labelDiakAtlag.Location = new System.Drawing.Point(15, 99);
            this.labelDiakAtlag.Name = "labelDiakAtlag";
            this.labelDiakAtlag.Size = new System.Drawing.Size(43, 13);
            this.labelDiakAtlag.TabIndex = 26;
            this.labelDiakAtlag.Text = "Fizetés:";
            // 
            // labelDiakEletkor
            // 
            this.labelDiakEletkor.AutoSize = true;
            this.labelDiakEletkor.Location = new System.Drawing.Point(15, 59);
            this.labelDiakEletkor.Name = "labelDiakEletkor";
            this.labelDiakEletkor.Size = new System.Drawing.Size(43, 13);
            this.labelDiakEletkor.TabIndex = 25;
            this.labelDiakEletkor.Text = "Életkor:";
            // 
            // labelDiakNev
            // 
            this.labelDiakNev.AutoSize = true;
            this.labelDiakNev.Location = new System.Drawing.Point(15, 23);
            this.labelDiakNev.Name = "labelDiakNev";
            this.labelDiakNev.Size = new System.Drawing.Size(30, 13);
            this.labelDiakNev.TabIndex = 24;
            this.labelDiakNev.Text = "Név:";
            // 
            // comboBoxMelyikOsztalybaHelyezzukAt
            // 
            this.comboBoxMelyikOsztalybaHelyezzukAt.FormattingEnabled = true;
            this.comboBoxMelyikOsztalybaHelyezzukAt.Location = new System.Drawing.Point(267, 457);
            this.comboBoxMelyikOsztalybaHelyezzukAt.Name = "comboBoxMelyikOsztalybaHelyezzukAt";
            this.comboBoxMelyikOsztalybaHelyezzukAt.Size = new System.Drawing.Size(197, 21);
            this.comboBoxMelyikOsztalybaHelyezzukAt.TabIndex = 24;
            // 
            // buttonKilepes
            // 
            this.buttonKilepes.Location = new System.Drawing.Point(883, 564);
            this.buttonKilepes.Name = "buttonKilepes";
            this.buttonKilepes.Size = new System.Drawing.Size(75, 23);
            this.buttonKilepes.TabIndex = 29;
            this.buttonKilepes.Text = "Kilépés";
            this.buttonKilepes.UseVisualStyleBackColor = true;
            this.buttonKilepes.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonMeghatarozOsztalyAtlag
            // 
            this.buttonMeghatarozOsztalyAtlag.Location = new System.Drawing.Point(267, 526);
            this.buttonMeghatarozOsztalyAtlag.Name = "buttonMeghatarozOsztalyAtlag";
            this.buttonMeghatarozOsztalyAtlag.Size = new System.Drawing.Size(297, 23);
            this.buttonMeghatarozOsztalyAtlag.TabIndex = 30;
            this.buttonMeghatarozOsztalyAtlag.Text = "Osztály átlag:";
            this.buttonMeghatarozOsztalyAtlag.UseVisualStyleBackColor = true;
            this.buttonMeghatarozOsztalyAtlag.Click += new System.EventHandler(this.buttonSzamolOsztalyAtlag_Click);
            // 
            // textBoxOsztalyAtlag
            // 
            this.textBoxOsztalyAtlag.Location = new System.Drawing.Point(267, 567);
            this.textBoxOsztalyAtlag.Name = "textBoxOsztalyAtlag";
            this.textBoxOsztalyAtlag.ReadOnly = true;
            this.textBoxOsztalyAtlag.Size = new System.Drawing.Size(297, 20);
            this.textBoxOsztalyAtlag.TabIndex = 31;
            // 
            // buttonMeghatarozIskolaAtlag
            // 
            this.buttonMeghatarozIskolaAtlag.Location = new System.Drawing.Point(37, 618);
            this.buttonMeghatarozIskolaAtlag.Name = "buttonMeghatarozIskolaAtlag";
            this.buttonMeghatarozIskolaAtlag.Size = new System.Drawing.Size(155, 23);
            this.buttonMeghatarozIskolaAtlag.TabIndex = 32;
            this.buttonMeghatarozIskolaAtlag.Text = "Iskola átlag:";
            this.buttonMeghatarozIskolaAtlag.UseVisualStyleBackColor = true;
            this.buttonMeghatarozIskolaAtlag.Click += new System.EventHandler(this.buttonMeghatarozIskolaAtlag_Click);
            // 
            // textBoxIskolaAtlag
            // 
            this.textBoxIskolaAtlag.Location = new System.Drawing.Point(37, 664);
            this.textBoxIskolaAtlag.Name = "textBoxIskolaAtlag";
            this.textBoxIskolaAtlag.ReadOnly = true;
            this.textBoxIskolaAtlag.Size = new System.Drawing.Size(155, 20);
            this.textBoxIskolaAtlag.TabIndex = 33;
            // 
            // errorProviderHozzadOsztalyt
            // 
            this.errorProviderHozzadOsztalyt.ContainerControl = this;
            // 
            // errorProviderModositOsztalyt
            // 
            this.errorProviderModositOsztalyt.ContainerControl = this;
            // 
            // errorProviderTorolOsztalyt
            // 
            this.errorProviderTorolOsztalyt.ContainerControl = this;
            // 
            // errorProviderDiakHozzaadasa
            // 
            this.errorProviderDiakHozzaadasa.ContainerControl = this;
            // 
            // errorProviderModositDiak
            // 
            this.errorProviderModositDiak.ContainerControl = this;
            // 
            // errorProviderTorolVersenyzo
            // 
            this.errorProviderTorolVersenyzo.ContainerControl = this;
            // 
            // buttonAthelyezDiakotMasikOsztalyba
            // 
            this.buttonAthelyezDiakotMasikOsztalyba.Location = new System.Drawing.Point(470, 457);
            this.buttonAthelyezDiakotMasikOsztalyba.Name = "buttonAthelyezDiakotMasikOsztalyba";
            this.buttonAthelyezDiakotMasikOsztalyba.Size = new System.Drawing.Size(94, 23);
            this.buttonAthelyezDiakotMasikOsztalyba.TabIndex = 34;
            this.buttonAthelyezDiakotMasikOsztalyba.Text = "csapatba átrak.";
            this.buttonAthelyezDiakotMasikOsztalyba.UseVisualStyleBackColor = true;
            this.buttonAthelyezDiakotMasikOsztalyba.Click += new System.EventHandler(this.buttonAthelyezDiakotMasikOsztalyba_Click);
            // 
            // errorProvideAthelyezDiakotMasikOsztalyba
            // 
            this.errorProvideAthelyezDiakotMasikOsztalyba.ContainerControl = this;
            // 
            // IskolaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.buttonAthelyezDiakotMasikOsztalyba);
            this.Controls.Add(this.textBoxIskolaAtlag);
            this.Controls.Add(this.buttonMeghatarozIskolaAtlag);
            this.Controls.Add(this.textBoxOsztalyAtlag);
            this.Controls.Add(this.buttonMeghatarozOsztalyAtlag);
            this.Controls.Add(this.buttonKilepes);
            this.Controls.Add(this.comboBoxMelyikOsztalybaHelyezzukAt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDiakok);
            this.Controls.Add(this.listBoxDiakok);
            this.Controls.Add(this.buttonTesztadatokBetoltese);
            this.Controls.Add(this.buttonTorolOsztalyt);
            this.Controls.Add(this.buttonModositOsztalyt);
            this.Controls.Add(this.buttonHozzadOsztalyt);
            this.Controls.Add(this.labelOsztalyNeve);
            this.Controls.Add(this.textBoxUjOsztalyAzonosito);
            this.Controls.Add(this.labelOsztalyok);
            this.Controls.Add(this.listBoxOsztalyok);
            this.Name = "IskolaForm";
            this.Text = "Iskola osztályainak és diákjainak kezelése";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHozzadOsztalyt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModositOsztalyt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTorolOsztalyt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDiakHozzaadasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModositDiak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTorolVersenyzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvideAthelyezDiakotMasikOsztalyba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTesztadatokBetoltese;
        private System.Windows.Forms.Button buttonTorolOsztalyt;
        private System.Windows.Forms.Button buttonModositOsztalyt;
        private System.Windows.Forms.Button buttonHozzadOsztalyt;
        private System.Windows.Forms.Label labelOsztalyNeve;
        private System.Windows.Forms.TextBox textBoxUjOsztalyAzonosito;
        private System.Windows.Forms.Label labelOsztalyok;
        private System.Windows.Forms.ListBox listBoxOsztalyok;
        private System.Windows.Forms.Button buttonTorolDiakot;
        private System.Windows.Forms.Button buttonModositDiak;
        private System.Windows.Forms.Button buttonHozzadDiak;
        private System.Windows.Forms.Label labelDiakok;
        private System.Windows.Forms.ListBox listBoxDiakok;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDiakAtlag;
        private System.Windows.Forms.Label labelDiakEletkor;
        private System.Windows.Forms.Label labelDiakNev;
        private System.Windows.Forms.ComboBox comboBoxMelyikOsztalybaHelyezzukAt;
        private System.Windows.Forms.TextBox textBoxDiakAtlag;
        private System.Windows.Forms.TextBox textBoxDiakEletkor;
        private System.Windows.Forms.TextBox textBoxDiakNev;
        private System.Windows.Forms.Button buttonKilepes;
        private System.Windows.Forms.Button buttonMeghatarozOsztalyAtlag;
        private System.Windows.Forms.TextBox textBoxOsztalyAtlag;
        private System.Windows.Forms.Button buttonMeghatarozIskolaAtlag;
        private System.Windows.Forms.TextBox textBoxIskolaAtlag;
        private System.Windows.Forms.ErrorProvider errorProviderHozzadOsztalyt;
        private System.Windows.Forms.ErrorProvider errorProviderModositOsztalyt;
        private System.Windows.Forms.ErrorProvider errorProviderTorolOsztalyt;
        private System.Windows.Forms.ErrorProvider errorProviderDiakHozzaadasa;
        private System.Windows.Forms.ErrorProvider errorProviderModositDiak;
        private System.Windows.Forms.ErrorProvider errorProviderTorolVersenyzo;
        private System.Windows.Forms.Button buttonAthelyezDiakotMasikOsztalyba;
        private System.Windows.Forms.ErrorProvider errorProvideAthelyezDiakotMasikOsztalyba;
    }
}

