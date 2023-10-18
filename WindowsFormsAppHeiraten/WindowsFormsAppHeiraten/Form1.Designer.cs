namespace WindowsFormsAppHeiraten
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.textBoxAlter = new System.Windows.Forms.TextBox();
            this.textBoxFamilienstand = new System.Windows.Forms.TextBox();
            this.buttonErschaffen = new System.Windows.Forms.Button();
            this.listBoxMenschen = new System.Windows.Forms.ListBox();
            this.buttonHeiraten = new System.Windows.Forms.Button();
            this.buttonGeburtstag = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFamilienstand);
            this.groupBox1.Controls.Add(this.textBoxAlter);
            this.groupBox1.Controls.Add(this.textBoxNachname);
            this.groupBox1.Controls.Add(this.textBoxVorname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mensch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vorname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nachname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Familienstand";
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(103, 24);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(132, 20);
            this.textBoxVorname.TabIndex = 4;
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Location = new System.Drawing.Point(103, 58);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(132, 20);
            this.textBoxNachname.TabIndex = 5;
            // 
            // textBoxAlter
            // 
            this.textBoxAlter.Location = new System.Drawing.Point(103, 90);
            this.textBoxAlter.Name = "textBoxAlter";
            this.textBoxAlter.Size = new System.Drawing.Size(132, 20);
            this.textBoxAlter.TabIndex = 6;
            // 
            // textBoxFamilienstand
            // 
            this.textBoxFamilienstand.Location = new System.Drawing.Point(103, 127);
            this.textBoxFamilienstand.Name = "textBoxFamilienstand";
            this.textBoxFamilienstand.Size = new System.Drawing.Size(132, 20);
            this.textBoxFamilienstand.TabIndex = 7;
            // 
            // buttonErschaffen
            // 
            this.buttonErschaffen.Location = new System.Drawing.Point(45, 251);
            this.buttonErschaffen.Name = "buttonErschaffen";
            this.buttonErschaffen.Size = new System.Drawing.Size(253, 29);
            this.buttonErschaffen.TabIndex = 1;
            this.buttonErschaffen.Text = "Mensch erschaffen";
            this.buttonErschaffen.UseVisualStyleBackColor = true;
            this.buttonErschaffen.Click += new System.EventHandler(this.buttonErschaffen_Click);
            // 
            // listBoxMenschen
            // 
            this.listBoxMenschen.FormattingEnabled = true;
            this.listBoxMenschen.Location = new System.Drawing.Point(383, 74);
            this.listBoxMenschen.Name = "listBoxMenschen";
            this.listBoxMenschen.Size = new System.Drawing.Size(264, 173);
            this.listBoxMenschen.TabIndex = 2;
            // 
            // buttonHeiraten
            // 
            this.buttonHeiraten.Location = new System.Drawing.Point(383, 253);
            this.buttonHeiraten.Name = "buttonHeiraten";
            this.buttonHeiraten.Size = new System.Drawing.Size(121, 29);
            this.buttonHeiraten.TabIndex = 3;
            this.buttonHeiraten.Text = "Heiraten";
            this.buttonHeiraten.UseVisualStyleBackColor = true;
            this.buttonHeiraten.Click += new System.EventHandler(this.buttonHeiraten_Click);
            // 
            // buttonGeburtstag
            // 
            this.buttonGeburtstag.Location = new System.Drawing.Point(526, 253);
            this.buttonGeburtstag.Name = "buttonGeburtstag";
            this.buttonGeburtstag.Size = new System.Drawing.Size(121, 30);
            this.buttonGeburtstag.TabIndex = 4;
            this.buttonGeburtstag.Text = "Geburtstag";
            this.buttonGeburtstag.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Neuer Nachname";
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(383, 321);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(121, 20);
            this.textBoxNewName.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonGeburtstag);
            this.Controls.Add(this.buttonHeiraten);
            this.Controls.Add(this.listBoxMenschen);
            this.Controls.Add(this.buttonErschaffen);
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
        private System.Windows.Forms.TextBox textBoxFamilienstand;
        private System.Windows.Forms.TextBox textBoxAlter;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonErschaffen;
        private System.Windows.Forms.ListBox listBoxMenschen;
        private System.Windows.Forms.Button buttonHeiraten;
        private System.Windows.Forms.Button buttonGeburtstag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNewName;
    }
}

