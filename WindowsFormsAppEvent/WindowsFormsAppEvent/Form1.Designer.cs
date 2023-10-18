namespace WindowsFormsAppEvent
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxAuswahl = new System.Windows.Forms.ListBox();
            this.buttonAuswerten = new System.Windows.Forms.Button();
            this.comboBoxFragen = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxAuswahl
            // 
            this.listBoxAuswahl.FormattingEnabled = true;
            this.listBoxAuswahl.Location = new System.Drawing.Point(46, 99);
            this.listBoxAuswahl.Name = "listBoxAuswahl";
            this.listBoxAuswahl.Size = new System.Drawing.Size(495, 121);
            this.listBoxAuswahl.TabIndex = 1;
            // 
            // buttonAuswerten
            // 
            this.buttonAuswerten.Location = new System.Drawing.Point(46, 257);
            this.buttonAuswerten.Name = "buttonAuswerten";
            this.buttonAuswerten.Size = new System.Drawing.Size(496, 23);
            this.buttonAuswerten.TabIndex = 2;
            this.buttonAuswerten.Text = "Auswerten";
            this.buttonAuswerten.UseVisualStyleBackColor = true;
            this.buttonAuswerten.Click += new System.EventHandler(this.buttonAuswerten_Click);
            // 
            // comboBoxFragen
            // 
            this.comboBoxFragen.FormattingEnabled = true;
            this.comboBoxFragen.Location = new System.Drawing.Point(46, 34);
            this.comboBoxFragen.Name = "comboBoxFragen";
            this.comboBoxFragen.Size = new System.Drawing.Size(495, 21);
            this.comboBoxFragen.TabIndex = 3;
            this.comboBoxFragen.SelectedIndexChanged += new System.EventHandler(this.comboBoxFragen_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 344);
            this.Controls.Add(this.comboBoxFragen);
            this.Controls.Add(this.buttonAuswerten);
            this.Controls.Add(this.listBoxAuswahl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAuswahl;
        private System.Windows.Forms.Button buttonAuswerten;
        private System.Windows.Forms.ComboBox comboBoxFragen;
    }
}

