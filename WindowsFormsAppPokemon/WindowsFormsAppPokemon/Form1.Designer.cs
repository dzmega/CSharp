namespace WindowsFormsAppPokemon
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
            this.comboBoxPokemon = new System.Windows.Forms.ComboBox();
            this.Uschrift = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPokemon
            // 
            this.comboBoxPokemon.FormattingEnabled = true;
            this.comboBoxPokemon.Location = new System.Drawing.Point(233, 143);
            this.comboBoxPokemon.Name = "comboBoxPokemon";
            this.comboBoxPokemon.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPokemon.TabIndex = 0;
            this.comboBoxPokemon.SelectedIndexChanged += new System.EventHandler(this.comboBoxPokemon_SelectedIndexChanged);
            // 
            // Uschrift
            // 
            this.Uschrift.AutoSize = true;
            this.Uschrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uschrift.Location = new System.Drawing.Point(103, 41);
            this.Uschrift.Name = "Uschrift";
            this.Uschrift.Size = new System.Drawing.Size(285, 25);
            this.Uschrift.TabIndex = 1;
            this.Uschrift.Text = "Meine Lieblingspokemons\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(272, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 229);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Uschrift);
            this.Controls.Add(this.comboBoxPokemon);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPokemon;
        private System.Windows.Forms.Label Uschrift;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

