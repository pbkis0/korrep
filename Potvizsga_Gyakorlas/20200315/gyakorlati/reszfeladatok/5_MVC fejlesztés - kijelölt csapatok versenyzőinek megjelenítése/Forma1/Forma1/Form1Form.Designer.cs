﻿namespace Forma1
{
    partial class Form1Form
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
            this.buttonInitializeData = new System.Windows.Forms.Button();
            this.buttonDeleteTeam = new System.Windows.Forms.Button();
            this.buttonUpdateTeam = new System.Windows.Forms.Button();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.labelTeam = new System.Windows.Forms.Label();
            this.listBoxTeam = new System.Windows.Forms.ListBox();
            this.buttonDeleteRacer = new System.Windows.Forms.Button();
            this.buttonUpdateRacer = new System.Windows.Forms.Button();
            this.buttonAddRacer = new System.Windows.Forms.Button();
            this.labelRecer = new System.Windows.Forms.Label();
            this.listBoxRacer = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxRacerSalary = new System.Windows.Forms.TextBox();
            this.textBoxRacerAge = new System.Windows.Forms.TextBox();
            this.textBoxRacerName = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelRacerAge = new System.Windows.Forms.Label();
            this.labelRacerName = new System.Windows.Forms.Label();
            this.comboBoxTeamMove = new System.Windows.Forms.ComboBox();
            this.labelMoveRacer = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonComputeTeamSalary = new System.Windows.Forms.Button();
            this.textBoxTeamSalary = new System.Windows.Forms.TextBox();
            this.buttonComputeF1Salary = new System.Windows.Forms.Button();
            this.textBoxF1Salary = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInitializeData
            // 
            this.buttonInitializeData.Location = new System.Drawing.Point(16, 27);
            this.buttonInitializeData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonInitializeData.Name = "buttonInitializeData";
            this.buttonInitializeData.Size = new System.Drawing.Size(240, 28);
            this.buttonInitializeData.TabIndex = 15;
            this.buttonInitializeData.Text = "Teszt adatok betöltése";
            this.buttonInitializeData.UseVisualStyleBackColor = true;
            this.buttonInitializeData.Click += new System.EventHandler(this.buttonInitializeData_Click);
            // 
            // buttonDeleteTeam
            // 
            this.buttonDeleteTeam.Location = new System.Drawing.Point(49, 694);
            this.buttonDeleteTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteTeam.Name = "buttonDeleteTeam";
            this.buttonDeleteTeam.Size = new System.Drawing.Size(100, 28);
            this.buttonDeleteTeam.TabIndex = 14;
            this.buttonDeleteTeam.Text = "Töröl";
            this.buttonDeleteTeam.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateTeam
            // 
            this.buttonUpdateTeam.Location = new System.Drawing.Point(49, 658);
            this.buttonUpdateTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpdateTeam.Name = "buttonUpdateTeam";
            this.buttonUpdateTeam.Size = new System.Drawing.Size(100, 28);
            this.buttonUpdateTeam.TabIndex = 13;
            this.buttonUpdateTeam.Text = "Módosít";
            this.buttonUpdateTeam.UseVisualStyleBackColor = true;
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.Location = new System.Drawing.Point(49, 623);
            this.buttonAddTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(100, 28);
            this.buttonAddTeam.TabIndex = 12;
            this.buttonAddTeam.Text = "Hozzáad";
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Location = new System.Drawing.Point(45, 544);
            this.labelTeamName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(91, 17);
            this.labelTeamName.TabIndex = 11;
            this.labelTeamName.Text = "Csapat neve:";
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Location = new System.Drawing.Point(49, 564);
            this.textBoxTeamName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(205, 22);
            this.textBoxTeamName.TabIndex = 10;
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Location = new System.Drawing.Point(45, 73);
            this.labelTeam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(129, 17);
            this.labelTeam.TabIndex = 9;
            this.labelTeam.Text = "Forma 1. csapatok:";
            // 
            // listBoxTeam
            // 
            this.listBoxTeam.FormattingEnabled = true;
            this.listBoxTeam.ItemHeight = 16;
            this.listBoxTeam.Location = new System.Drawing.Point(49, 107);
            this.listBoxTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxTeam.Name = "listBoxTeam";
            this.listBoxTeam.Size = new System.Drawing.Size(205, 404);
            this.listBoxTeam.TabIndex = 8;
            this.listBoxTeam.SelectedIndexChanged += new System.EventHandler(this.ListBoxTeam_SelectedIndexChanged);
            // 
            // buttonDeleteRacer
            // 
            this.buttonDeleteRacer.Location = new System.Drawing.Point(299, 219);
            this.buttonDeleteRacer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteRacer.Name = "buttonDeleteRacer";
            this.buttonDeleteRacer.Size = new System.Drawing.Size(100, 28);
            this.buttonDeleteRacer.TabIndex = 22;
            this.buttonDeleteRacer.Text = "Töröl";
            this.buttonDeleteRacer.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateRacer
            // 
            this.buttonUpdateRacer.Location = new System.Drawing.Point(163, 219);
            this.buttonUpdateRacer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpdateRacer.Name = "buttonUpdateRacer";
            this.buttonUpdateRacer.Size = new System.Drawing.Size(100, 28);
            this.buttonUpdateRacer.TabIndex = 21;
            this.buttonUpdateRacer.Text = "Módosít";
            this.buttonUpdateRacer.UseVisualStyleBackColor = true;
            // 
            // buttonAddRacer
            // 
            this.buttonAddRacer.Location = new System.Drawing.Point(24, 219);
            this.buttonAddRacer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddRacer.Name = "buttonAddRacer";
            this.buttonAddRacer.Size = new System.Drawing.Size(100, 28);
            this.buttonAddRacer.TabIndex = 20;
            this.buttonAddRacer.Text = "Hozzáad";
            this.buttonAddRacer.UseVisualStyleBackColor = true;
            // 
            // labelRecer
            // 
            this.labelRecer.AutoSize = true;
            this.labelRecer.Location = new System.Drawing.Point(352, 73);
            this.labelRecer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecer.Name = "labelRecer";
            this.labelRecer.Size = new System.Drawing.Size(152, 17);
            this.labelRecer.TabIndex = 17;
            this.labelRecer.Text = "Forma 1. csapat tagjai:";
            // 
            // listBoxRacer
            // 
            this.listBoxRacer.FormattingEnabled = true;
            this.listBoxRacer.ItemHeight = 16;
            this.listBoxRacer.Location = new System.Drawing.Point(356, 107);
            this.listBoxRacer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxRacer.Name = "listBoxRacer";
            this.listBoxRacer.Size = new System.Drawing.Size(395, 404);
            this.listBoxRacer.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxRacerSalary);
            this.panel1.Controls.Add(this.textBoxRacerAge);
            this.panel1.Controls.Add(this.textBoxRacerName);
            this.panel1.Controls.Add(this.labelSalary);
            this.panel1.Controls.Add(this.labelRacerAge);
            this.panel1.Controls.Add(this.labelRacerName);
            this.panel1.Controls.Add(this.buttonDeleteRacer);
            this.panel1.Controls.Add(this.buttonAddRacer);
            this.panel1.Controls.Add(this.buttonUpdateRacer);
            this.panel1.Location = new System.Drawing.Point(812, 107);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 295);
            this.panel1.TabIndex = 23;
            // 
            // textBoxRacerSalary
            // 
            this.textBoxRacerSalary.Location = new System.Drawing.Point(115, 118);
            this.textBoxRacerSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRacerSalary.Name = "textBoxRacerSalary";
            this.textBoxRacerSalary.Size = new System.Drawing.Size(312, 22);
            this.textBoxRacerSalary.TabIndex = 28;
            // 
            // textBoxRacerAge
            // 
            this.textBoxRacerAge.Location = new System.Drawing.Point(115, 64);
            this.textBoxRacerAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRacerAge.Name = "textBoxRacerAge";
            this.textBoxRacerAge.Size = new System.Drawing.Size(312, 22);
            this.textBoxRacerAge.TabIndex = 27;
            // 
            // textBoxRacerName
            // 
            this.textBoxRacerName.Location = new System.Drawing.Point(68, 20);
            this.textBoxRacerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRacerName.Name = "textBoxRacerName";
            this.textBoxRacerName.Size = new System.Drawing.Size(359, 22);
            this.textBoxRacerName.TabIndex = 26;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(20, 122);
            this.labelSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(57, 17);
            this.labelSalary.TabIndex = 26;
            this.labelSalary.Text = "Fizetés:";
            // 
            // labelRacerAge
            // 
            this.labelRacerAge.AutoSize = true;
            this.labelRacerAge.Location = new System.Drawing.Point(20, 73);
            this.labelRacerAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRacerAge.Name = "labelRacerAge";
            this.labelRacerAge.Size = new System.Drawing.Size(56, 17);
            this.labelRacerAge.TabIndex = 25;
            this.labelRacerAge.Text = "Életkor:";
            // 
            // labelRacerName
            // 
            this.labelRacerName.AutoSize = true;
            this.labelRacerName.Location = new System.Drawing.Point(20, 28);
            this.labelRacerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRacerName.Name = "labelRacerName";
            this.labelRacerName.Size = new System.Drawing.Size(37, 17);
            this.labelRacerName.TabIndex = 24;
            this.labelRacerName.Text = "Név:";
            // 
            // comboBoxTeamMove
            // 
            this.comboBoxTeamMove.FormattingEnabled = true;
            this.comboBoxTeamMove.Location = new System.Drawing.Point(356, 562);
            this.comboBoxTeamMove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTeamMove.Name = "comboBoxTeamMove";
            this.comboBoxTeamMove.Size = new System.Drawing.Size(279, 24);
            this.comboBoxTeamMove.TabIndex = 24;
            // 
            // labelMoveRacer
            // 
            this.labelMoveRacer.AutoSize = true;
            this.labelMoveRacer.Location = new System.Drawing.Point(644, 572);
            this.labelMoveRacer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMoveRacer.Name = "labelMoveRacer";
            this.labelMoveRacer.Size = new System.Drawing.Size(106, 17);
            this.labelMoveRacer.TabIndex = 25;
            this.labelMoveRacer.Text = "csapatba átrak.";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1177, 694);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 28);
            this.buttonExit.TabIndex = 29;
            this.buttonExit.Text = "Kilépés";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonComputeTeamSalary
            // 
            this.buttonComputeTeamSalary.Location = new System.Drawing.Point(356, 647);
            this.buttonComputeTeamSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonComputeTeamSalary.Name = "buttonComputeTeamSalary";
            this.buttonComputeTeamSalary.Size = new System.Drawing.Size(396, 28);
            this.buttonComputeTeamSalary.TabIndex = 30;
            this.buttonComputeTeamSalary.Text = "Csapat össz bérkifeizetése:";
            this.buttonComputeTeamSalary.UseVisualStyleBackColor = true;
            // 
            // textBoxTeamSalary
            // 
            this.textBoxTeamSalary.Location = new System.Drawing.Point(356, 698);
            this.textBoxTeamSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTeamSalary.Name = "textBoxTeamSalary";
            this.textBoxTeamSalary.ReadOnly = true;
            this.textBoxTeamSalary.Size = new System.Drawing.Size(395, 22);
            this.textBoxTeamSalary.TabIndex = 31;
            // 
            // buttonComputeF1Salary
            // 
            this.buttonComputeF1Salary.Location = new System.Drawing.Point(49, 761);
            this.buttonComputeF1Salary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonComputeF1Salary.Name = "buttonComputeF1Salary";
            this.buttonComputeF1Salary.Size = new System.Drawing.Size(207, 28);
            this.buttonComputeF1Salary.TabIndex = 32;
            this.buttonComputeF1Salary.Text = "F1 össz bérkifeizetése:";
            this.buttonComputeF1Salary.UseVisualStyleBackColor = true;
            // 
            // textBoxF1Salary
            // 
            this.textBoxF1Salary.Location = new System.Drawing.Point(49, 817);
            this.textBoxF1Salary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxF1Salary.Name = "textBoxF1Salary";
            this.textBoxF1Salary.ReadOnly = true;
            this.textBoxF1Salary.Size = new System.Drawing.Size(205, 22);
            this.textBoxF1Salary.TabIndex = 33;
            // 
            // Form1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.textBoxF1Salary);
            this.Controls.Add(this.buttonComputeF1Salary);
            this.Controls.Add(this.textBoxTeamSalary);
            this.Controls.Add(this.buttonComputeTeamSalary);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelMoveRacer);
            this.Controls.Add(this.comboBoxTeamMove);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelRecer);
            this.Controls.Add(this.listBoxRacer);
            this.Controls.Add(this.buttonInitializeData);
            this.Controls.Add(this.buttonDeleteTeam);
            this.Controls.Add(this.buttonUpdateTeam);
            this.Controls.Add(this.buttonAddTeam);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.textBoxTeamName);
            this.Controls.Add(this.labelTeam);
            this.Controls.Add(this.listBoxTeam);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1Form";
            this.Text = "Forma 1.";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInitializeData;
        private System.Windows.Forms.Button buttonDeleteTeam;
        private System.Windows.Forms.Button buttonUpdateTeam;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.ListBox listBoxTeam;
        private System.Windows.Forms.Button buttonDeleteRacer;
        private System.Windows.Forms.Button buttonUpdateRacer;
        private System.Windows.Forms.Button buttonAddRacer;
        private System.Windows.Forms.Label labelRecer;
        private System.Windows.Forms.ListBox listBoxRacer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelRacerAge;
        private System.Windows.Forms.Label labelRacerName;
        private System.Windows.Forms.ComboBox comboBoxTeamMove;
        private System.Windows.Forms.Label labelMoveRacer;
        private System.Windows.Forms.TextBox textBoxRacerSalary;
        private System.Windows.Forms.TextBox textBoxRacerAge;
        private System.Windows.Forms.TextBox textBoxRacerName;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonComputeTeamSalary;
        private System.Windows.Forms.TextBox textBoxTeamSalary;
        private System.Windows.Forms.Button buttonComputeF1Salary;
        private System.Windows.Forms.TextBox textBoxF1Salary;
    }
}

