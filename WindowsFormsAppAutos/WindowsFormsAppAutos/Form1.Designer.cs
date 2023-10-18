namespace WindowsFormsAppAutos
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
            this.textBoxKennzeichen = new System.Windows.Forms.TextBox();
            this.textBoxVerbrauch = new System.Windows.Forms.TextBox();
            this.textBoxKM = new System.Windows.Forms.TextBox();
            this.textBoxMenge = new System.Windows.Forms.TextBox();
            this.autoErzeugen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxAutos = new System.Windows.Forms.ListBox();
            this.alleAutos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.autoErzeugen);
            this.groupBox1.Controls.Add(this.textBoxMenge);
            this.groupBox1.Controls.Add(this.textBoxKM);
            this.groupBox1.Controls.Add(this.textBoxVerbrauch);
            this.groupBox1.Controls.Add(this.textBoxKennzeichen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(54, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto aufnehmen";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kennzeichen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Verbrauch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "KMStand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Füllmenge";
            // 
            // textBoxKennzeichen
            // 
            this.textBoxKennzeichen.Location = new System.Drawing.Point(140, 26);
            this.textBoxKennzeichen.Name = "textBoxKennzeichen";
            this.textBoxKennzeichen.Size = new System.Drawing.Size(100, 20);
            this.textBoxKennzeichen.TabIndex = 4;
            // 
            // textBoxVerbrauch
            // 
            this.textBoxVerbrauch.Location = new System.Drawing.Point(140, 55);
            this.textBoxVerbrauch.Name = "textBoxVerbrauch";
            this.textBoxVerbrauch.Size = new System.Drawing.Size(100, 20);
            this.textBoxVerbrauch.TabIndex = 5;
            // 
            // textBoxKM
            // 
            this.textBoxKM.Location = new System.Drawing.Point(140, 89);
            this.textBoxKM.Name = "textBoxKM";
            this.textBoxKM.Size = new System.Drawing.Size(100, 20);
            this.textBoxKM.TabIndex = 6;
            // 
            // textBoxMenge
            // 
            this.textBoxMenge.Location = new System.Drawing.Point(140, 121);
            this.textBoxMenge.Name = "textBoxMenge";
            this.textBoxMenge.Size = new System.Drawing.Size(100, 20);
            this.textBoxMenge.TabIndex = 7;
            // 
            // autoErzeugen
            // 
            this.autoErzeugen.Location = new System.Drawing.Point(26, 158);
            this.autoErzeugen.Name = "autoErzeugen";
            this.autoErzeugen.Size = new System.Drawing.Size(214, 23);
            this.autoErzeugen.TabIndex = 8;
            this.autoErzeugen.Text = "Autoobjekt erzeugen";
            this.autoErzeugen.UseVisualStyleBackColor = true;
            this.autoErzeugen.Click += new System.EventHandler(this.autoErzeugen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.alleAutos);
            this.groupBox2.Controls.Add(this.listBoxAutos);
            this.groupBox2.Location = new System.Drawing.Point(434, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 178);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Autos anzeigen";
            // 
            // listBoxAutos
            // 
            this.listBoxAutos.FormattingEnabled = true;
            this.listBoxAutos.Location = new System.Drawing.Point(6, 17);
            this.listBoxAutos.Name = "listBoxAutos";
            this.listBoxAutos.Size = new System.Drawing.Size(256, 121);
            this.listBoxAutos.TabIndex = 0;
            this.listBoxAutos.SelectedIndexChanged += new System.EventHandler(this.listBoxAutos_SelectedIndexChanged);
            // 
            // alleAutos
            // 
            this.alleAutos.Location = new System.Drawing.Point(6, 149);
            this.alleAutos.Name = "alleAutos";
            this.alleAutos.Size = new System.Drawing.Size(256, 23);
            this.alleAutos.TabIndex = 1;
            this.alleAutos.Text = "Alle Autos anzeigen";
            this.alleAutos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Autos verwalten";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button autoErzeugen;
        private System.Windows.Forms.TextBox textBoxMenge;
        private System.Windows.Forms.TextBox textBoxKM;
        private System.Windows.Forms.TextBox textBoxVerbrauch;
        private System.Windows.Forms.TextBox textBoxKennzeichen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button alleAutos;
        private System.Windows.Forms.ListBox listBoxAutos;
    }
}

