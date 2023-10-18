namespace WindowsFormsAppHaustiermanager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxHundeStNr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGewicht = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonRassekatze = new System.Windows.Forms.RadioButton();
            this.radioButtonKatze = new System.Windows.Forms.RadioButton();
            this.radioButtonHund = new System.Windows.Forms.RadioButton();
            this.buttonAufnehmen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTiere = new System.Windows.Forms.ComboBox();
            this.listBoxTiere = new System.Windows.Forms.ListBox();
            this.buttonFüttern = new System.Windows.Forms.Button();
            this.buttonImpfen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxHundeStNr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxGewicht);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButtonRassekatze);
            this.groupBox1.Controls.Add(this.radioButtonKatze);
            this.groupBox1.Controls.Add(this.radioButtonHund);
            this.groupBox1.Location = new System.Drawing.Point(36, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Haustier";
            // 
            // textBoxHundeStNr
            // 
            this.textBoxHundeStNr.Location = new System.Drawing.Point(6, 213);
            this.textBoxHundeStNr.Name = "textBoxHundeStNr";
            this.textBoxHundeStNr.Size = new System.Drawing.Size(172, 20);
            this.textBoxHundeStNr.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hundesteuernummer";
            // 
            // textBoxGewicht
            // 
            this.textBoxGewicht.Location = new System.Drawing.Point(6, 150);
            this.textBoxGewicht.Name = "textBoxGewicht";
            this.textBoxGewicht.Size = new System.Drawing.Size(172, 20);
            this.textBoxGewicht.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gewicht";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(6, 96);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(172, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // radioButtonRassekatze
            // 
            this.radioButtonRassekatze.AutoSize = true;
            this.radioButtonRassekatze.Location = new System.Drawing.Point(153, 19);
            this.radioButtonRassekatze.Name = "radioButtonRassekatze";
            this.radioButtonRassekatze.Size = new System.Drawing.Size(81, 17);
            this.radioButtonRassekatze.TabIndex = 2;
            this.radioButtonRassekatze.TabStop = true;
            this.radioButtonRassekatze.Text = "Rassekatze";
            this.radioButtonRassekatze.UseVisualStyleBackColor = true;
            this.radioButtonRassekatze.CheckedChanged += new System.EventHandler(this.radioButtonRassekatze_CheckedChanged);
            // 
            // radioButtonKatze
            // 
            this.radioButtonKatze.AutoSize = true;
            this.radioButtonKatze.Location = new System.Drawing.Point(77, 19);
            this.radioButtonKatze.Name = "radioButtonKatze";
            this.radioButtonKatze.Size = new System.Drawing.Size(52, 17);
            this.radioButtonKatze.TabIndex = 1;
            this.radioButtonKatze.TabStop = true;
            this.radioButtonKatze.Text = "Katze";
            this.radioButtonKatze.UseVisualStyleBackColor = true;
            this.radioButtonKatze.CheckedChanged += new System.EventHandler(this.radioButtonKatze_CheckedChanged);
            // 
            // radioButtonHund
            // 
            this.radioButtonHund.AutoSize = true;
            this.radioButtonHund.Location = new System.Drawing.Point(6, 19);
            this.radioButtonHund.Name = "radioButtonHund";
            this.radioButtonHund.Size = new System.Drawing.Size(51, 17);
            this.radioButtonHund.TabIndex = 0;
            this.radioButtonHund.TabStop = true;
            this.radioButtonHund.Text = "Hund";
            this.radioButtonHund.UseVisualStyleBackColor = true;
            this.radioButtonHund.CheckedChanged += new System.EventHandler(this.radioButtonHund_CheckedChanged);
            // 
            // buttonAufnehmen
            // 
            this.buttonAufnehmen.Location = new System.Drawing.Point(36, 292);
            this.buttonAufnehmen.Name = "buttonAufnehmen";
            this.buttonAufnehmen.Size = new System.Drawing.Size(129, 61);
            this.buttonAufnehmen.TabIndex = 1;
            this.buttonAufnehmen.Text = "Neues Tier";
            this.buttonAufnehmen.UseVisualStyleBackColor = true;
            this.buttonAufnehmen.Click += new System.EventHandler(this.buttonAufnehmen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tier wählen";
            // 
            // comboBoxTiere
            // 
            this.comboBoxTiere.FormattingEnabled = true;
            this.comboBoxTiere.Location = new System.Drawing.Point(392, 47);
            this.comboBoxTiere.Name = "comboBoxTiere";
            this.comboBoxTiere.Size = new System.Drawing.Size(187, 21);
            this.comboBoxTiere.TabIndex = 3;
            // 
            // listBoxTiere
            // 
            this.listBoxTiere.FormattingEnabled = true;
            this.listBoxTiere.Location = new System.Drawing.Point(392, 75);
            this.listBoxTiere.Name = "listBoxTiere";
            this.listBoxTiere.Size = new System.Drawing.Size(187, 147);
            this.listBoxTiere.TabIndex = 4;
            // 
            // buttonFüttern
            // 
            this.buttonFüttern.Location = new System.Drawing.Point(392, 228);
            this.buttonFüttern.Name = "buttonFüttern";
            this.buttonFüttern.Size = new System.Drawing.Size(86, 58);
            this.buttonFüttern.TabIndex = 5;
            this.buttonFüttern.Text = "Füttern";
            this.buttonFüttern.UseVisualStyleBackColor = true;
            this.buttonFüttern.Click += new System.EventHandler(this.buttonFüttern_Click);
            // 
            // buttonImpfen
            // 
            this.buttonImpfen.Location = new System.Drawing.Point(493, 228);
            this.buttonImpfen.Name = "buttonImpfen";
            this.buttonImpfen.Size = new System.Drawing.Size(86, 58);
            this.buttonImpfen.TabIndex = 6;
            this.buttonImpfen.Text = "Impfen";
            this.buttonImpfen.UseVisualStyleBackColor = true;
            this.buttonImpfen.Click += new System.EventHandler(this.buttonImpfen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 380);
            this.Controls.Add(this.buttonImpfen);
            this.Controls.Add(this.buttonFüttern);
            this.Controls.Add(this.listBoxTiere);
            this.Controls.Add(this.comboBoxTiere);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAufnehmen);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxHundeStNr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGewicht;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonRassekatze;
        private System.Windows.Forms.RadioButton radioButtonKatze;
        private System.Windows.Forms.RadioButton radioButtonHund;
        private System.Windows.Forms.Button buttonAufnehmen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTiere;
        private System.Windows.Forms.ListBox listBoxTiere;
        private System.Windows.Forms.Button buttonFüttern;
        private System.Windows.Forms.Button buttonImpfen;
    }
}

