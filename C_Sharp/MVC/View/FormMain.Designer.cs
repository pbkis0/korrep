namespace MVC.View
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxCRUD = new System.Windows.Forms.GroupBox();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.comboBoxAlcohol = new System.Windows.Forms.ComboBox();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAlcohol = new System.Windows.Forms.Label();
            this.groupBoxCRUD.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxData
            // 
            this.listBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(12, 12);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(662, 316);
            this.listBoxData.TabIndex = 0;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(115, 37);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(135, 23);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Új";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(256, 37);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(135, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Módosítás";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(397, 37);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(135, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Törlés";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // groupBoxCRUD
            // 
            this.groupBoxCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCRUD.Controls.Add(this.buttonCreate);
            this.groupBoxCRUD.Controls.Add(this.buttonUpdate);
            this.groupBoxCRUD.Controls.Add(this.buttonDelete);
            this.groupBoxCRUD.Location = new System.Drawing.Point(12, 333);
            this.groupBoxCRUD.Name = "groupBoxCRUD";
            this.groupBoxCRUD.Size = new System.Drawing.Size(662, 92);
            this.groupBoxCRUD.TabIndex = 4;
            this.groupBoxCRUD.TabStop = false;
            this.groupBoxCRUD.Text = "C-R-U-D";
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFilter.Controls.Add(this.labelAlcohol);
            this.groupBoxFilter.Controls.Add(this.label1);
            this.groupBoxFilter.Controls.Add(this.comboBoxManufacturer);
            this.groupBoxFilter.Controls.Add(this.comboBoxAlcohol);
            this.groupBoxFilter.Location = new System.Drawing.Point(12, 432);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(662, 99);
            this.groupBoxFilter.TabIndex = 5;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Szűrés";
            // 
            // comboBoxAlcohol
            // 
            this.comboBoxAlcohol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAlcohol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlcohol.FormattingEnabled = true;
            this.comboBoxAlcohol.Location = new System.Drawing.Point(397, 46);
            this.comboBoxAlcohol.Name = "comboBoxAlcohol";
            this.comboBoxAlcohol.Size = new System.Drawing.Size(179, 21);
            this.comboBoxAlcohol.TabIndex = 0;
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(115, 46);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(179, 21);
            this.comboBoxManufacturer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gyártó:";
            // 
            // labelAlcohol
            // 
            this.labelAlcohol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAlcohol.AutoSize = true;
            this.labelAlcohol.Location = new System.Drawing.Point(306, 49);
            this.labelAlcohol.Name = "labelAlcohol";
            this.labelAlcohol.Size = new System.Drawing.Size(85, 13);
            this.labelAlcohol.TabIndex = 3;
            this.labelAlcohol.Text = "Alkohol tartalom:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 543);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.groupBoxCRUD);
            this.Controls.Add(this.listBoxData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MVC Gyakorló Projekt";
            this.groupBoxCRUD.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxCRUD;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.ComboBox comboBoxManufacturer;
        private System.Windows.Forms.ComboBox comboBoxAlcohol;
        private System.Windows.Forms.Label labelAlcohol;
        private System.Windows.Forms.Label label1;
    }
}

