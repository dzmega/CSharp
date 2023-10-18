namespace WindowsFormsAppBMI
{
    partial class BMIfürMänner
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
            this.bmiUeberschrift = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGewicht = new System.Windows.Forms.TextBox();
            this.textBoxGröße = new System.Windows.Forms.TextBox();
            this.berechnenButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBMI = new System.Windows.Forms.TextBox();
            this.textBoxKlassifikation = new System.Windows.Forms.TextBox();
            this.pictureBoxBild = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBild)).BeginInit();
            this.SuspendLayout();
            // 
            // bmiUeberschrift
            // 
            this.bmiUeberschrift.AutoSize = true;
            this.bmiUeberschrift.BackColor = System.Drawing.SystemColors.Control;
            this.bmiUeberschrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmiUeberschrift.ForeColor = System.Drawing.Color.DarkGreen;
            this.bmiUeberschrift.Location = new System.Drawing.Point(193, 31);
            this.bmiUeberschrift.Name = "bmiUeberschrift";
            this.bmiUeberschrift.Size = new System.Drawing.Size(152, 24);
            this.bmiUeberschrift.TabIndex = 0;
            this.bmiUeberschrift.Text = "BMI für Männer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gewicht in kg:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Größe in Meter:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxGewicht
            // 
            this.textBoxGewicht.Location = new System.Drawing.Point(133, 161);
            this.textBoxGewicht.Name = "textBoxGewicht";
            this.textBoxGewicht.Size = new System.Drawing.Size(100, 20);
            this.textBoxGewicht.TabIndex = 3;
            this.textBoxGewicht.TextChanged += new System.EventHandler(this.textBoxGewicht_TextChanged);
            // 
            // textBoxGröße
            // 
            this.textBoxGröße.Location = new System.Drawing.Point(133, 195);
            this.textBoxGröße.Name = "textBoxGröße";
            this.textBoxGröße.Size = new System.Drawing.Size(100, 20);
            this.textBoxGröße.TabIndex = 4;
            // 
            // berechnenButton
            // 
            this.berechnenButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.berechnenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.berechnenButton.Location = new System.Drawing.Point(74, 262);
            this.berechnenButton.Name = "berechnenButton";
            this.berechnenButton.Size = new System.Drawing.Size(159, 53);
            this.berechnenButton.TabIndex = 5;
            this.berechnenButton.Text = "BERECHNEN";
            this.berechnenButton.UseVisualStyleBackColor = false;
            this.berechnenButton.Click += new System.EventHandler(this.berechnenButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "BMI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Klassifikation:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxBMI
            // 
            this.textBoxBMI.Location = new System.Drawing.Point(378, 164);
            this.textBoxBMI.Name = "textBoxBMI";
            this.textBoxBMI.Size = new System.Drawing.Size(100, 20);
            this.textBoxBMI.TabIndex = 8;
            // 
            // textBoxKlassifikation
            // 
            this.textBoxKlassifikation.Location = new System.Drawing.Point(378, 199);
            this.textBoxKlassifikation.Name = "textBoxKlassifikation";
            this.textBoxKlassifikation.Size = new System.Drawing.Size(100, 20);
            this.textBoxKlassifikation.TabIndex = 9;
            // 
            // pictureBoxBild
            // 
            this.pictureBoxBild.Location = new System.Drawing.Point(258, 277);
            this.pictureBoxBild.Name = "pictureBoxBild";
            this.pictureBoxBild.Size = new System.Drawing.Size(220, 149);
            this.pictureBoxBild.TabIndex = 10;
            this.pictureBoxBild.TabStop = false;
            // 
            // BMIfürMänner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxBild);
            this.Controls.Add(this.textBoxKlassifikation);
            this.Controls.Add(this.textBoxBMI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.berechnenButton);
            this.Controls.Add(this.textBoxGröße);
            this.Controls.Add(this.textBoxGewicht);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bmiUeberschrift);
            this.Name = "BMIfürMänner";
            this.Text = "BMIfürMänner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bmiUeberschrift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGewicht;
        private System.Windows.Forms.TextBox textBoxGröße;
        private System.Windows.Forms.Button berechnenButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBMI;
        private System.Windows.Forms.TextBox textBoxKlassifikation;
        private System.Windows.Forms.PictureBox pictureBoxBild;
    }
}

