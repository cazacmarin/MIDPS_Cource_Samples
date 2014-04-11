namespace MIDPS1_XML_linq
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
            this.buttonParsingXML = new System.Windows.Forms.Button();
            this.buttonXmlReader = new System.Windows.Forms.Button();
            this.buttonWriteToXML = new System.Windows.Forms.Button();
            this.buttonReadXMLWithLinq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonParsingXML
            // 
            this.buttonParsingXML.Location = new System.Drawing.Point(31, 24);
            this.buttonParsingXML.Name = "buttonParsingXML";
            this.buttonParsingXML.Size = new System.Drawing.Size(105, 23);
            this.buttonParsingXML.TabIndex = 0;
            this.buttonParsingXML.Text = "Parsing XML";
            this.buttonParsingXML.UseVisualStyleBackColor = true;
            this.buttonParsingXML.Click += new System.EventHandler(this.buttonParsingXML_Click);
            // 
            // buttonXmlReader
            // 
            this.buttonXmlReader.Location = new System.Drawing.Point(31, 69);
            this.buttonXmlReader.Name = "buttonXmlReader";
            this.buttonXmlReader.Size = new System.Drawing.Size(105, 23);
            this.buttonXmlReader.TabIndex = 1;
            this.buttonXmlReader.Text = "Xml Reader";
            this.buttonXmlReader.UseVisualStyleBackColor = true;
            this.buttonXmlReader.Click += new System.EventHandler(this.buttonXmlReader_Click);
            // 
            // buttonWriteToXML
            // 
            this.buttonWriteToXML.Location = new System.Drawing.Point(31, 118);
            this.buttonWriteToXML.Name = "buttonWriteToXML";
            this.buttonWriteToXML.Size = new System.Drawing.Size(105, 23);
            this.buttonWriteToXML.TabIndex = 2;
            this.buttonWriteToXML.Text = "Write To Xml";
            this.buttonWriteToXML.UseVisualStyleBackColor = true;
            this.buttonWriteToXML.Click += new System.EventHandler(this.buttonWriteToXML_Click);
            // 
            // buttonReadXMLWithLinq
            // 
            this.buttonReadXMLWithLinq.Location = new System.Drawing.Point(31, 159);
            this.buttonReadXMLWithLinq.Name = "buttonReadXMLWithLinq";
            this.buttonReadXMLWithLinq.Size = new System.Drawing.Size(146, 23);
            this.buttonReadXMLWithLinq.TabIndex = 3;
            this.buttonReadXMLWithLinq.Text = "Read XML With Linq";
            this.buttonReadXMLWithLinq.UseVisualStyleBackColor = true;
            this.buttonReadXMLWithLinq.Click += new System.EventHandler(this.buttonReadXMLWithLinq_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.buttonReadXMLWithLinq);
            this.Controls.Add(this.buttonWriteToXML);
            this.Controls.Add(this.buttonXmlReader);
            this.Controls.Add(this.buttonParsingXML);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonParsingXML;
        private System.Windows.Forms.Button buttonXmlReader;
        private System.Windows.Forms.Button buttonWriteToXML;
        private System.Windows.Forms.Button buttonReadXMLWithLinq;
    }
}

