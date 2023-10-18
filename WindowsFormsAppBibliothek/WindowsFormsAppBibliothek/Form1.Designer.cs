namespace WindowsFormsAppBibliothek
{
    partial class labelVerfügbarkeit
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
            this.comboBoxBuecher = new System.Windows.Forms.ComboBox();
            this.buttonAusleihen = new System.Windows.Forms.Button();
            this.buttonZurückgeben = new System.Windows.Forms.Button();
            this.labelAngabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxBuecher
            // 
            this.comboBoxBuecher.FormattingEnabled = true;
            this.comboBoxBuecher.Location = new System.Drawing.Point(84, 113);
            this.comboBoxBuecher.Name = "comboBoxBuecher";
            this.comboBoxBuecher.Size = new System.Drawing.Size(350, 21);
            this.comboBoxBuecher.TabIndex = 0;
            this.comboBoxBuecher.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonAusleihen
            // 
            this.buttonAusleihen.Location = new System.Drawing.Point(511, 113);
            this.buttonAusleihen.Name = "buttonAusleihen";
            this.buttonAusleihen.Size = new System.Drawing.Size(84, 23);
            this.buttonAusleihen.TabIndex = 1;
            this.buttonAusleihen.Text = "Ausleihen";
            this.buttonAusleihen.UseVisualStyleBackColor = true;
            this.buttonAusleihen.Click += new System.EventHandler(this.buttonAusleihen_Click);
            // 
            // buttonZurückgeben
            // 
            this.buttonZurückgeben.Location = new System.Drawing.Point(511, 160);
            this.buttonZurückgeben.Name = "buttonZurückgeben";
            this.buttonZurückgeben.Size = new System.Drawing.Size(84, 23);
            this.buttonZurückgeben.TabIndex = 2;
            this.buttonZurückgeben.Text = "Zurückgeben";
            this.buttonZurückgeben.UseVisualStyleBackColor = true;
            this.buttonZurückgeben.Click += new System.EventHandler(this.buttonZurückgeben_Click);
            // 
            // labelAngabe
            // 
            this.labelAngabe.AutoSize = true;
            this.labelAngabe.Location = new System.Drawing.Point(100, 160);
            this.labelAngabe.Name = "labelAngabe";
            this.labelAngabe.Size = new System.Drawing.Size(35, 13);
            this.labelAngabe.TabIndex = 3;
            this.labelAngabe.Text = "label1";
            // 
            // labelVerfügbarkeit
            // 
            this.ClientSize = new System.Drawing.Size(643, 500);
            this.Controls.Add(this.labelAngabe);
            this.Controls.Add(this.buttonZurückgeben);
            this.Controls.Add(this.buttonAusleihen);
            this.Controls.Add(this.comboBoxBuecher);
            this.Name = "labelVerfügbarkeit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBuecher;
        private System.Windows.Forms.Button buttonAusleihen;
        private System.Windows.Forms.Button buttonZurückgeben;
        private System.Windows.Forms.Label labelAngabe;
    }
}

