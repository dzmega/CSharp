namespace WindowsFormsAppZoo
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
            this.buttonFüttern = new System.Windows.Forms.Button();
            this.listBoxTier = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonFüttern
            // 
            this.buttonFüttern.Location = new System.Drawing.Point(570, 177);
            this.buttonFüttern.Name = "buttonFüttern";
            this.buttonFüttern.Size = new System.Drawing.Size(109, 52);
            this.buttonFüttern.TabIndex = 0;
            this.buttonFüttern.Text = "Füttern";
            this.buttonFüttern.UseVisualStyleBackColor = true;
            this.buttonFüttern.Click += new System.EventHandler(this.buttonFüttern_Click);
            // 
            // listBoxTier
            // 
            this.listBoxTier.FormattingEnabled = true;
            this.listBoxTier.Location = new System.Drawing.Point(110, 104);
            this.listBoxTier.Name = "listBoxTier";
            this.listBoxTier.Size = new System.Drawing.Size(307, 199);
            this.listBoxTier.TabIndex = 1;
            this.listBoxTier.SelectedIndexChanged += new System.EventHandler(this.listBoxTier_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxTier);
            this.Controls.Add(this.buttonFüttern);
            this.Name = "Form1";
            this.Text = "e";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFüttern;
        private System.Windows.Forms.ListBox listBoxTier;
    }
}

