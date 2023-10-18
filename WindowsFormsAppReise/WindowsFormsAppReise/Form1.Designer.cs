namespace WindowsFormsAppReise
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
            this.Email = new System.Windows.Forms.Label();
            this.Vorname = new System.Windows.Forms.Label();
            this.Nachname = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.buttonEntfernen = new System.Windows.Forms.Button();
            this.textBoxReise = new System.Windows.Forms.TextBox();
            this.buttonAufnehmen = new System.Windows.Forms.Button();
            this.listBoxReise = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMaxTN = new System.Windows.Forms.TextBox();
            this.textBoxBis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVon = new System.Windows.Forms.TextBox();
            this.textBoxPreis = new System.Windows.Forms.TextBox();
            this.textBoxZiel = new System.Windows.Forms.TextBox();
            this.buttonReiseAufnehmen = new System.Windows.Forms.Button();
            this.listBoxTeilnehmer = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.Vorname);
            this.groupBox1.Controls.Add(this.Nachname);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.textBoxVorname);
            this.groupBox1.Controls.Add(this.textBoxNachname);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(458, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neuer Teilnehmer";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(226, 113);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(50, 18);
            this.Email.TabIndex = 5;
            this.Email.Text = "Email";
            // 
            // Vorname
            // 
            this.Vorname.AutoSize = true;
            this.Vorname.Location = new System.Drawing.Point(226, 70);
            this.Vorname.Name = "Vorname";
            this.Vorname.Size = new System.Drawing.Size(75, 18);
            this.Vorname.TabIndex = 4;
            this.Vorname.Text = "Vorname";
            // 
            // Nachname
            // 
            this.Nachname.AutoSize = true;
            this.Nachname.Location = new System.Drawing.Point(226, 32);
            this.Nachname.Name = "Nachname";
            this.Nachname.Size = new System.Drawing.Size(88, 18);
            this.Nachname.TabIndex = 3;
            this.Nachname.Text = "Nachname";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(67, 110);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(126, 24);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(67, 70);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(126, 24);
            this.textBoxVorname.TabIndex = 1;
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Location = new System.Drawing.Point(67, 32);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(126, 24);
            this.textBoxNachname.TabIndex = 0;
            this.textBoxNachname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonEntfernen
            // 
            this.buttonEntfernen.Location = new System.Drawing.Point(543, 450);
            this.buttonEntfernen.Name = "buttonEntfernen";
            this.buttonEntfernen.Size = new System.Drawing.Size(191, 23);
            this.buttonEntfernen.TabIndex = 3;
            this.buttonEntfernen.Text = "Teilnehmer entfernen";
            this.buttonEntfernen.UseVisualStyleBackColor = true;
            this.buttonEntfernen.Click += new System.EventHandler(this.buttonEntfernen_Click);
            // 
            // textBoxReise
            // 
            this.textBoxReise.Location = new System.Drawing.Point(282, 12);
            this.textBoxReise.Name = "textBoxReise";
            this.textBoxReise.Size = new System.Drawing.Size(388, 20);
            this.textBoxReise.TabIndex = 4;
            this.textBoxReise.TextChanged += new System.EventHandler(this.textBoxReise_TextChanged);
            // 
            // buttonAufnehmen
            // 
            this.buttonAufnehmen.Location = new System.Drawing.Point(848, 324);
            this.buttonAufnehmen.Name = "buttonAufnehmen";
            this.buttonAufnehmen.Size = new System.Drawing.Size(91, 102);
            this.buttonAufnehmen.TabIndex = 6;
            this.buttonAufnehmen.Text = "Neuen Teilnehmer aufnehmen";
            this.buttonAufnehmen.UseVisualStyleBackColor = true;
            this.buttonAufnehmen.Click += new System.EventHandler(this.buttonAufnehmen_Click);
            // 
            // listBoxReise
            // 
            this.listBoxReise.FormattingEnabled = true;
            this.listBoxReise.Location = new System.Drawing.Point(25, 73);
            this.listBoxReise.Name = "listBoxReise";
            this.listBoxReise.Size = new System.Drawing.Size(417, 186);
            this.listBoxReise.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxMaxTN);
            this.groupBox2.Controls.Add(this.textBoxBis);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxVon);
            this.groupBox2.Controls.Add(this.textBoxPreis);
            this.groupBox2.Controls.Add(this.textBoxZiel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(458, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 188);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Neuer Teilnehmer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "MaxTN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bis";
            // 
            // textBoxMaxTN
            // 
            this.textBoxMaxTN.Location = new System.Drawing.Point(67, 143);
            this.textBoxMaxTN.Name = "textBoxMaxTN";
            this.textBoxMaxTN.Size = new System.Drawing.Size(126, 24);
            this.textBoxMaxTN.TabIndex = 7;
            // 
            // textBoxBis
            // 
            this.textBoxBis.Location = new System.Drawing.Point(67, 113);
            this.textBoxBis.Name = "textBoxBis";
            this.textBoxBis.Size = new System.Drawing.Size(126, 24);
            this.textBoxBis.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Von";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ziel";
            // 
            // textBoxVon
            // 
            this.textBoxVon.Location = new System.Drawing.Point(67, 83);
            this.textBoxVon.Name = "textBoxVon";
            this.textBoxVon.Size = new System.Drawing.Size(126, 24);
            this.textBoxVon.TabIndex = 2;
            // 
            // textBoxPreis
            // 
            this.textBoxPreis.Location = new System.Drawing.Point(67, 53);
            this.textBoxPreis.Name = "textBoxPreis";
            this.textBoxPreis.Size = new System.Drawing.Size(126, 24);
            this.textBoxPreis.TabIndex = 1;
            // 
            // textBoxZiel
            // 
            this.textBoxZiel.Location = new System.Drawing.Point(67, 23);
            this.textBoxZiel.Name = "textBoxZiel";
            this.textBoxZiel.Size = new System.Drawing.Size(126, 24);
            this.textBoxZiel.TabIndex = 0;
            // 
            // buttonReiseAufnehmen
            // 
            this.buttonReiseAufnehmen.Location = new System.Drawing.Point(848, 116);
            this.buttonReiseAufnehmen.Name = "buttonReiseAufnehmen";
            this.buttonReiseAufnehmen.Size = new System.Drawing.Size(91, 102);
            this.buttonReiseAufnehmen.TabIndex = 9;
            this.buttonReiseAufnehmen.Text = "Neue Reise aufnehmen";
            this.buttonReiseAufnehmen.UseVisualStyleBackColor = true;
            this.buttonReiseAufnehmen.Click += new System.EventHandler(this.buttonReiseAufnehmen_Click);
            // 
            // listBoxTeilnehmer
            // 
            this.listBoxTeilnehmer.FormattingEnabled = true;
            this.listBoxTeilnehmer.Location = new System.Drawing.Point(25, 275);
            this.listBoxTeilnehmer.Name = "listBoxTeilnehmer";
            this.listBoxTeilnehmer.Size = new System.Drawing.Size(417, 186);
            this.listBoxTeilnehmer.TabIndex = 10;
            this.listBoxTeilnehmer.SelectedIndexChanged += new System.EventHandler(this.listBoxTeilnehmer_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 485);
            this.Controls.Add(this.listBoxTeilnehmer);
            this.Controls.Add(this.buttonReiseAufnehmen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBoxReise);
            this.Controls.Add(this.buttonAufnehmen);
            this.Controls.Add(this.textBoxReise);
            this.Controls.Add(this.buttonEntfernen);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Vorname;
        private System.Windows.Forms.Label Nachname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.Button buttonEntfernen;
        private System.Windows.Forms.TextBox textBoxReise;
        private System.Windows.Forms.Button buttonAufnehmen;
        private System.Windows.Forms.ListBox listBoxReise;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMaxTN;
        private System.Windows.Forms.TextBox textBoxBis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVon;
        private System.Windows.Forms.TextBox textBoxPreis;
        private System.Windows.Forms.TextBox textBoxZiel;
        private System.Windows.Forms.Button buttonReiseAufnehmen;
        private System.Windows.Forms.ListBox listBoxTeilnehmer;
    }
}

