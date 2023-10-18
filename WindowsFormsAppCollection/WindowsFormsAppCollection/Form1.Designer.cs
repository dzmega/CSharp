namespace WindowsFormsAppCollection
{
    partial class listBoxSchüler
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxGeburtstag = new System.Windows.Forms.TextBox();
            this.textBoxWohnort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.schülerAufnehmen = new System.Windows.Forms.Button();
            this.schülerEntlassen = new System.Windows.Forms.Button();
            this.listBoxSchueler = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(86, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxGeburtstag
            // 
            this.textBoxGeburtstag.Location = new System.Drawing.Point(86, 98);
            this.textBoxGeburtstag.Name = "textBoxGeburtstag";
            this.textBoxGeburtstag.Size = new System.Drawing.Size(100, 20);
            this.textBoxGeburtstag.TabIndex = 1;
            // 
            // textBoxWohnort
            // 
            this.textBoxWohnort.Location = new System.Drawing.Point(86, 162);
            this.textBoxWohnort.Name = "textBoxWohnort";
            this.textBoxWohnort.Size = new System.Drawing.Size(100, 20);
            this.textBoxWohnort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Geburtstag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wohnort";
            // 
            // schülerAufnehmen
            // 
            this.schülerAufnehmen.Location = new System.Drawing.Point(86, 209);
            this.schülerAufnehmen.Name = "schülerAufnehmen";
            this.schülerAufnehmen.Size = new System.Drawing.Size(100, 50);
            this.schülerAufnehmen.TabIndex = 6;
            this.schülerAufnehmen.Text = "Schüler aufnehemen";
            this.schülerAufnehmen.UseVisualStyleBackColor = true;
            this.schülerAufnehmen.Click += new System.EventHandler(this.schülerAufnehmen_Click);
            // 
            // schülerEntlassen
            // 
            this.schülerEntlassen.Location = new System.Drawing.Point(86, 277);
            this.schülerEntlassen.Name = "schülerEntlassen";
            this.schülerEntlassen.Size = new System.Drawing.Size(100, 52);
            this.schülerEntlassen.TabIndex = 7;
            this.schülerEntlassen.Text = "Schüler entlassen";
            this.schülerEntlassen.UseVisualStyleBackColor = true;
            this.schülerEntlassen.Click += new System.EventHandler(this.schülerEntlassen_Click);
            // 
            // listBoxSchueler
            // 
            this.listBoxSchueler.FormattingEnabled = true;
            this.listBoxSchueler.Location = new System.Drawing.Point(336, 79);
            this.listBoxSchueler.Name = "listBoxSchueler";
            this.listBoxSchueler.Size = new System.Drawing.Size(378, 212);
            this.listBoxSchueler.TabIndex = 8;
            this.listBoxSchueler.SelectedIndexChanged += new System.EventHandler(this.listBoxSchueler_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Schülerliste";
            // 
            // listBoxSchüler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxSchueler);
            this.Controls.Add(this.schülerEntlassen);
            this.Controls.Add(this.schülerAufnehmen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWohnort);
            this.Controls.Add(this.textBoxGeburtstag);
            this.Controls.Add(this.textBoxName);
            this.Name = "listBoxSchüler";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxGeburtstag;
        private System.Windows.Forms.TextBox textBoxWohnort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button schülerAufnehmen;
        private System.Windows.Forms.Button schülerEntlassen;
        private System.Windows.Forms.ListBox listBoxSchueler;
        private System.Windows.Forms.Label label4;
    }
}

