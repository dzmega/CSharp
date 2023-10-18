namespace WindowsFormsAppQuadratzahl
{
    partial class Quadratzahl
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
            this.labelUeberschrift = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxEingabe = new System.Windows.Forms.TextBox();
            this.textboxAusgabe = new System.Windows.Forms.TextBox();
            this.berechnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUeberschrift
            // 
            this.labelUeberschrift.AutoSize = true;
            this.labelUeberschrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUeberschrift.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelUeberschrift.Location = new System.Drawing.Point(131, 74);
            this.labelUeberschrift.Name = "labelUeberschrift";
            this.labelUeberschrift.Size = new System.Drawing.Size(107, 20);
            this.labelUeberschrift.TabIndex = 0;
            this.labelUeberschrift.Text = "Quadratzahl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bitte Zahl eingeben:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Die Quadratzahl lautet:";
            // 
            // textboxEingabe
            // 
            this.textboxEingabe.Location = new System.Drawing.Point(86, 247);
            this.textboxEingabe.Name = "textboxEingabe";
            this.textboxEingabe.Size = new System.Drawing.Size(100, 20);
            this.textboxEingabe.TabIndex = 3;
            this.textboxEingabe.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textboxAusgabe
            // 
            this.textboxAusgabe.Location = new System.Drawing.Point(349, 247);
            this.textboxAusgabe.Name = "textboxAusgabe";
            this.textboxAusgabe.Size = new System.Drawing.Size(100, 20);
            this.textboxAusgabe.TabIndex = 4;
            // 
            // berechnen
            // 
            this.berechnen.BackColor = System.Drawing.Color.Red;
            this.berechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.berechnen.Location = new System.Drawing.Point(76, 354);
            this.berechnen.Name = "berechnen";
            this.berechnen.Size = new System.Drawing.Size(174, 63);
            this.berechnen.TabIndex = 5;
            this.berechnen.Text = "BERECHNEN";
            this.berechnen.UseVisualStyleBackColor = false;
            this.berechnen.Click += new System.EventHandler(this.berechnen_Click);
            // 
            // Quadratzahl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.berechnen);
            this.Controls.Add(this.textboxAusgabe);
            this.Controls.Add(this.textboxEingabe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUeberschrift);
            this.Name = "Quadratzahl";
            this.Text = "Quadratzahl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUeberschrift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxEingabe;
        private System.Windows.Forms.TextBox textboxAusgabe;
        private System.Windows.Forms.Button berechnen;
    }
}

