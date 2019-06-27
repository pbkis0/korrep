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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxCRUD = new System.Windows.Forms.GroupBox();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.buttonFilterAlcohol = new System.Windows.Forms.Button();
            this.buttonFilterManufacturer = new System.Windows.Forms.Button();
            this.labelAlcohol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.comboBoxAlcohol = new System.Windows.Forms.ComboBox();
            this.errorProviderTorlesHiba = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxCRUD.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTorlesHiba)).BeginInit();
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
            this.listBoxData.Size = new System.Drawing.Size(662, 342);
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
            this.buttonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(397, 37);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(135, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Törlés";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // groupBoxCRUD
            // 
            this.groupBoxCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCRUD.Controls.Add(this.buttonCreate);
            this.groupBoxCRUD.Controls.Add(this.buttonDelete);
            this.groupBoxCRUD.Location = new System.Drawing.Point(12, 366);
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
            this.groupBoxFilter.Controls.Add(this.buttonFilterAlcohol);
            this.groupBoxFilter.Controls.Add(this.buttonFilterManufacturer);
            this.groupBoxFilter.Controls.Add(this.labelAlcohol);
            this.groupBoxFilter.Controls.Add(this.label1);
            this.groupBoxFilter.Controls.Add(this.comboBoxManufacturer);
            this.groupBoxFilter.Controls.Add(this.comboBoxAlcohol);
            this.groupBoxFilter.Location = new System.Drawing.Point(12, 465);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(662, 99);
            this.groupBoxFilter.TabIndex = 5;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Szűrés";
            // 
            // buttonFilterAlcohol
            // 
            this.buttonFilterAlcohol.Location = new System.Drawing.Point(397, 49);
            this.buttonFilterAlcohol.Name = "buttonFilterAlcohol";
            this.buttonFilterAlcohol.Size = new System.Drawing.Size(179, 23);
            this.buttonFilterAlcohol.TabIndex = 5;
            this.buttonFilterAlcohol.Text = "Szűrés alkoholtartalomra";
            this.buttonFilterAlcohol.UseVisualStyleBackColor = true;
            this.buttonFilterAlcohol.Click += new System.EventHandler(this.ButtonFilterAlcohol_Click);
            // 
            // buttonFilterManufacturer
            // 
            this.buttonFilterManufacturer.Location = new System.Drawing.Point(115, 49);
            this.buttonFilterManufacturer.Name = "buttonFilterManufacturer";
            this.buttonFilterManufacturer.Size = new System.Drawing.Size(179, 23);
            this.buttonFilterManufacturer.TabIndex = 4;
            this.buttonFilterManufacturer.Text = "Szűrés gyártóra";
            this.buttonFilterManufacturer.UseVisualStyleBackColor = true;
            this.buttonFilterManufacturer.Click += new System.EventHandler(this.ButtonFilterManufacturer_Click);
            // 
            // labelAlcohol
            // 
            this.labelAlcohol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAlcohol.AutoSize = true;
            this.labelAlcohol.Location = new System.Drawing.Point(306, 25);
            this.labelAlcohol.Name = "labelAlcohol";
            this.labelAlcohol.Size = new System.Drawing.Size(85, 13);
            this.labelAlcohol.TabIndex = 3;
            this.labelAlcohol.Text = "Alkohol tartalom:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gyártó:";
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(115, 22);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(179, 21);
            this.comboBoxManufacturer.TabIndex = 1;
            // 
            // comboBoxAlcohol
            // 
            this.comboBoxAlcohol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAlcohol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlcohol.FormattingEnabled = true;
            this.comboBoxAlcohol.Location = new System.Drawing.Point(397, 22);
            this.comboBoxAlcohol.Name = "comboBoxAlcohol";
            this.comboBoxAlcohol.Size = new System.Drawing.Size(179, 21);
            this.comboBoxAlcohol.TabIndex = 0;
            // 
            // errorProviderTorlesHiba
            // 
            this.errorProviderTorlesHiba.ContainerControl = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 576);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.groupBoxCRUD);
            this.Controls.Add(this.listBoxData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MVC Gyakorló Projekt";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCRUD.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTorlesHiba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxCRUD;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.ComboBox comboBoxManufacturer;
        private System.Windows.Forms.ComboBox comboBoxAlcohol;
        private System.Windows.Forms.Label labelAlcohol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFilterAlcohol;
        private System.Windows.Forms.Button buttonFilterManufacturer;
        private System.Windows.Forms.ErrorProvider errorProviderTorlesHiba;
    }
}

