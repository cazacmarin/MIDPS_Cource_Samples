﻿namespace FormsApp
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.InsertingAddressGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonDeleteAddress = new System.Windows.Forms.Button();
            this.dataGridViewAddress = new System.Windows.Forms.DataGridView();
            this.buttonSaveAddress = new System.Windows.Forms.Button();
            this.labelLocation = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.insertingEMail = new System.Windows.Forms.GroupBox();
            this.buttonSaveEMail = new System.Windows.Forms.Button();
            this.comboBoxEMailType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxEMailAddress = new System.Windows.Forms.TextBox();
            this.labelEMailAddress = new System.Windows.Forms.Label();
            this.agendaGoupBox = new System.Windows.Forms.GroupBox();
            this.dataGridViewEMailAddress = new System.Windows.Forms.DataGridView();
            this.InsertingAddressGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddress)).BeginInit();
            this.insertingEMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEMailAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertingAddressGroupBox
            // 
            this.InsertingAddressGroupBox.Controls.Add(this.buttonDeleteAddress);
            this.InsertingAddressGroupBox.Controls.Add(this.dataGridViewAddress);
            this.InsertingAddressGroupBox.Controls.Add(this.buttonSaveAddress);
            this.InsertingAddressGroupBox.Controls.Add(this.labelLocation);
            this.InsertingAddressGroupBox.Controls.Add(this.comboBoxType);
            this.InsertingAddressGroupBox.Controls.Add(this.textBoxStreet);
            this.InsertingAddressGroupBox.Controls.Add(this.labelStreet);
            this.InsertingAddressGroupBox.Controls.Add(this.labelCity);
            this.InsertingAddressGroupBox.Controls.Add(this.textBoxCity);
            this.InsertingAddressGroupBox.Location = new System.Drawing.Point(12, 12);
            this.InsertingAddressGroupBox.Name = "InsertingAddressGroupBox";
            this.InsertingAddressGroupBox.Size = new System.Drawing.Size(1161, 100);
            this.InsertingAddressGroupBox.TabIndex = 0;
            this.InsertingAddressGroupBox.TabStop = false;
            this.InsertingAddressGroupBox.Text = "Inserting Address";
            // 
            // buttonDeleteAddress
            // 
            this.buttonDeleteAddress.Location = new System.Drawing.Point(1013, 21);
            this.buttonDeleteAddress.Name = "buttonDeleteAddress";
            this.buttonDeleteAddress.Size = new System.Drawing.Size(127, 23);
            this.buttonDeleteAddress.TabIndex = 8;
            this.buttonDeleteAddress.Text = "Delete Address";
            this.buttonDeleteAddress.UseVisualStyleBackColor = true;
            this.buttonDeleteAddress.Click += new System.EventHandler(this.buttonDeleteAddress_Click);
            // 
            // dataGridViewAddress
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAddress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAddress.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAddress.Location = new System.Drawing.Point(526, 16);
            this.dataGridViewAddress.Name = "dataGridViewAddress";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAddress.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAddress.RowTemplate.Height = 24;
            this.dataGridViewAddress.Size = new System.Drawing.Size(481, 78);
            this.dataGridViewAddress.TabIndex = 7;
            // 
            // buttonSaveAddress
            // 
            this.buttonSaveAddress.Location = new System.Drawing.Point(349, 61);
            this.buttonSaveAddress.Name = "buttonSaveAddress";
            this.buttonSaveAddress.Size = new System.Drawing.Size(155, 23);
            this.buttonSaveAddress.TabIndex = 6;
            this.buttonSaveAddress.Text = "Save Address";
            this.buttonSaveAddress.UseVisualStyleBackColor = true;
            this.buttonSaveAddress.Click += new System.EventHandler(this.buttonSaveAddress_Click);
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(277, 21);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(66, 17);
            this.labelLocation.TabIndex = 5;
            this.labelLocation.Text = "Location:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Work",
            "Home"});
            this.comboBoxType.Location = new System.Drawing.Point(349, 16);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(155, 24);
            this.comboBoxType.TabIndex = 4;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(71, 58);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(196, 22);
            this.textBoxStreet.TabIndex = 3;
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(4, 61);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(50, 17);
            this.labelStreet.TabIndex = 2;
            this.labelStreet.Text = "Street:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(19, 21);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(35, 17);
            this.labelCity.TabIndex = 1;
            this.labelCity.Text = "City:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(71, 18);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(196, 22);
            this.textBoxCity.TabIndex = 0;
            // 
            // insertingEMail
            // 
            this.insertingEMail.Controls.Add(this.dataGridViewEMailAddress);
            this.insertingEMail.Controls.Add(this.buttonSaveEMail);
            this.insertingEMail.Controls.Add(this.comboBoxEMailType);
            this.insertingEMail.Controls.Add(this.labelType);
            this.insertingEMail.Controls.Add(this.textBoxEMailAddress);
            this.insertingEMail.Controls.Add(this.labelEMailAddress);
            this.insertingEMail.Location = new System.Drawing.Point(12, 118);
            this.insertingEMail.Name = "insertingEMail";
            this.insertingEMail.Size = new System.Drawing.Size(994, 100);
            this.insertingEMail.TabIndex = 1;
            this.insertingEMail.TabStop = false;
            this.insertingEMail.Text = "Inserting e-mail address";
            // 
            // buttonSaveEMail
            // 
            this.buttonSaveEMail.Location = new System.Drawing.Point(267, 59);
            this.buttonSaveEMail.Name = "buttonSaveEMail";
            this.buttonSaveEMail.Size = new System.Drawing.Size(91, 23);
            this.buttonSaveEMail.TabIndex = 4;
            this.buttonSaveEMail.Text = "Save EMail";
            this.buttonSaveEMail.UseVisualStyleBackColor = true;
            this.buttonSaveEMail.Click += new System.EventHandler(this.buttonSaveEMail_Click);
            // 
            // comboBoxEMailType
            // 
            this.comboBoxEMailType.FormattingEnabled = true;
            this.comboBoxEMailType.Items.AddRange(new object[] {
            "Work",
            "Home"});
            this.comboBoxEMailType.Location = new System.Drawing.Point(116, 59);
            this.comboBoxEMailType.Name = "comboBoxEMailType";
            this.comboBoxEMailType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEMailType.TabIndex = 3;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(44, 59);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(66, 17);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Location:";
            // 
            // textBoxEMailAddress
            // 
            this.textBoxEMailAddress.Location = new System.Drawing.Point(116, 21);
            this.textBoxEMailAddress.Name = "textBoxEMailAddress";
            this.textBoxEMailAddress.Size = new System.Drawing.Size(150, 22);
            this.textBoxEMailAddress.TabIndex = 1;
            // 
            // labelEMailAddress
            // 
            this.labelEMailAddress.AutoSize = true;
            this.labelEMailAddress.Location = new System.Drawing.Point(4, 24);
            this.labelEMailAddress.Name = "labelEMailAddress";
            this.labelEMailAddress.Size = new System.Drawing.Size(106, 17);
            this.labelEMailAddress.TabIndex = 0;
            this.labelEMailAddress.Text = "E-mail address:";
            // 
            // agendaGoupBox
            // 
            this.agendaGoupBox.Location = new System.Drawing.Point(12, 233);
            this.agendaGoupBox.Name = "agendaGoupBox";
            this.agendaGoupBox.Size = new System.Drawing.Size(620, 100);
            this.agendaGoupBox.TabIndex = 2;
            this.agendaGoupBox.TabStop = false;
            this.agendaGoupBox.Text = "Inserting Agenda";
            // 
            // dataGridViewEMailAddress
            // 
            this.dataGridViewEMailAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEMailAddress.Location = new System.Drawing.Point(526, 10);
            this.dataGridViewEMailAddress.Name = "dataGridViewEMailAddress";
            this.dataGridViewEMailAddress.RowTemplate.Height = 24;
            this.dataGridViewEMailAddress.Size = new System.Drawing.Size(481, 90);
            this.dataGridViewEMailAddress.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 373);
            this.Controls.Add(this.agendaGoupBox);
            this.Controls.Add(this.insertingEMail);
            this.Controls.Add(this.InsertingAddressGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.InsertingAddressGroupBox.ResumeLayout(false);
            this.InsertingAddressGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddress)).EndInit();
            this.insertingEMail.ResumeLayout(false);
            this.insertingEMail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEMailAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox InsertingAddressGroupBox;
        private System.Windows.Forms.GroupBox insertingEMail;
        private System.Windows.Forms.GroupBox agendaGoupBox;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Button buttonSaveAddress;
        private System.Windows.Forms.DataGridView dataGridViewAddress;
        private System.Windows.Forms.Button buttonDeleteAddress;
        private System.Windows.Forms.TextBox textBoxEMailAddress;
        private System.Windows.Forms.Label labelEMailAddress;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxEMailType;
        private System.Windows.Forms.Button buttonSaveEMail;
        private System.Windows.Forms.DataGridView dataGridViewEMailAddress;
    }
}
