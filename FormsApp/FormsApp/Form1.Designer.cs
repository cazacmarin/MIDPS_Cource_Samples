namespace FormsApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridViewEMailAddress = new System.Windows.Forms.DataGridView();
            this.buttonSaveEMail = new System.Windows.Forms.Button();
            this.comboBoxEMailType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxEMailAddress = new System.Windows.Forms.TextBox();
            this.labelEMailAddress = new System.Windows.Forms.Label();
            this.agendaGoupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonImportAddressTableFromXML = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAddress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAddress.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAddress.Location = new System.Drawing.Point(526, 16);
            this.dataGridViewAddress.Name = "dataGridViewAddress";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAddress.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            // dataGridViewEMailAddress
            // 
            this.dataGridViewEMailAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEMailAddress.Location = new System.Drawing.Point(526, 10);
            this.dataGridViewEMailAddress.Name = "dataGridViewEMailAddress";
            this.dataGridViewEMailAddress.RowTemplate.Height = 24;
            this.dataGridViewEMailAddress.Size = new System.Drawing.Size(481, 90);
            this.dataGridViewEMailAddress.TabIndex = 5;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Create 2nd XML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(656, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "ReadXML";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(795, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Save Address To Xml";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonImportAddressTableFromXML
            // 
            this.buttonImportAddressTableFromXML.Location = new System.Drawing.Point(795, 287);
            this.buttonImportAddressTableFromXML.Name = "buttonImportAddressTableFromXML";
            this.buttonImportAddressTableFromXML.Size = new System.Drawing.Size(188, 23);
            this.buttonImportAddressTableFromXML.TabIndex = 7;
            this.buttonImportAddressTableFromXML.Text = "Import Address From XML";
            this.buttonImportAddressTableFromXML.UseVisualStyleBackColor = true;
            this.buttonImportAddressTableFromXML.Click += new System.EventHandler(this.buttonImportAddressTableFromXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 373);
            this.Controls.Add(this.buttonImportAddressTableFromXML);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonImportAddressTableFromXML;
    }
}

