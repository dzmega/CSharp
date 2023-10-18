namespace WindowsFormsAppObjektBewegen
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
            this.buttonUp = new System.Windows.Forms.Button();
            this.labelDennis = new System.Windows.Forms.Label();
            this.labelLeon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(45, 28);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(75, 23);
            this.buttonUp.TabIndex = 0;
            this.buttonUp.Text = "UP!";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // labelDennis
            // 
            this.labelDennis.AutoSize = true;
            this.labelDennis.Location = new System.Drawing.Point(304, 310);
            this.labelDennis.Name = "labelDennis";
            this.labelDennis.Size = new System.Drawing.Size(40, 13);
            this.labelDennis.TabIndex = 1;
            this.labelDennis.Text = "Dennis";
            // 
            // labelLeon
            // 
            this.labelLeon.AutoSize = true;
            this.labelLeon.Location = new System.Drawing.Point(485, 310);
            this.labelLeon.Name = "labelLeon";
            this.labelLeon.Size = new System.Drawing.Size(31, 13);
            this.labelLeon.TabIndex = 2;
            this.labelLeon.Text = "Leon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLeon);
            this.Controls.Add(this.labelDennis);
            this.Controls.Add(this.buttonUp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Label labelDennis;
        private System.Windows.Forms.Label labelLeon;
    }
}

