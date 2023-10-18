namespace WindowsFormsAppBrutto_Netto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNetto = new System.Windows.Forms.TextBox();
            this.bruttoButton = new System.Windows.Forms.Button();
            this.nettoButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lowRadioButton = new System.Windows.Forms.RadioButton();
            this.highRadioButton = new System.Windows.Forms.RadioButton();
            this.textBoxBrutto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nettopreis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bruttopreis";
            // 
            // textBoxNetto
            // 
            this.textBoxNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNetto.Location = new System.Drawing.Point(272, 53);
            this.textBoxNetto.Name = "textBoxNetto";
            this.textBoxNetto.Size = new System.Drawing.Size(117, 22);
            this.textBoxNetto.TabIndex = 2;
            // 
            // bruttoButton
            // 
            this.bruttoButton.Location = new System.Drawing.Point(116, 131);
            this.bruttoButton.Name = "bruttoButton";
            this.bruttoButton.Size = new System.Drawing.Size(122, 23);
            this.bruttoButton.TabIndex = 3;
            this.bruttoButton.Text = "Bruttopreis berechnen";
            this.bruttoButton.UseVisualStyleBackColor = true;
            this.bruttoButton.Click += new System.EventHandler(this.bruttoButton_Click);
            // 
            // nettoButton
            // 
            this.nettoButton.Location = new System.Drawing.Point(272, 131);
            this.nettoButton.Name = "nettoButton";
            this.nettoButton.Size = new System.Drawing.Size(117, 23);
            this.nettoButton.TabIndex = 4;
            this.nettoButton.Text = "Nettopreis berechnen";
            this.nettoButton.UseVisualStyleBackColor = true;
            this.nettoButton.Click += new System.EventHandler(this.nettoButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mehrwertsteuerzusatz auswählen";
            // 
            // lowRadioButton
            // 
            this.lowRadioButton.AutoSize = true;
            this.lowRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowRadioButton.Location = new System.Drawing.Point(132, 260);
            this.lowRadioButton.Name = "lowRadioButton";
            this.lowRadioButton.Size = new System.Drawing.Size(52, 24);
            this.lowRadioButton.TabIndex = 6;
            this.lowRadioButton.TabStop = true;
            this.lowRadioButton.Text = "7%";
            this.lowRadioButton.UseVisualStyleBackColor = true;
            // 
            // highRadioButton
            // 
            this.highRadioButton.AutoSize = true;
            this.highRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highRadioButton.Location = new System.Drawing.Point(272, 260);
            this.highRadioButton.Name = "highRadioButton";
            this.highRadioButton.Size = new System.Drawing.Size(62, 24);
            this.highRadioButton.TabIndex = 7;
            this.highRadioButton.TabStop = true;
            this.highRadioButton.Text = "19%";
            this.highRadioButton.UseVisualStyleBackColor = true;
            // 
            // textBoxBrutto
            // 
            this.textBoxBrutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBrutto.Location = new System.Drawing.Point(272, 339);
            this.textBoxBrutto.Name = "textBoxBrutto";
            this.textBoxBrutto.Size = new System.Drawing.Size(117, 22);
            this.textBoxBrutto.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxBrutto);
            this.Controls.Add(this.highRadioButton);
            this.Controls.Add(this.lowRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nettoButton);
            this.Controls.Add(this.bruttoButton);
            this.Controls.Add(this.textBoxNetto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNetto;
        private System.Windows.Forms.Button bruttoButton;
        private System.Windows.Forms.Button nettoButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton lowRadioButton;
        private System.Windows.Forms.RadioButton highRadioButton;
        private System.Windows.Forms.TextBox textBoxBrutto;
    }
}

