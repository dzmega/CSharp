namespace WindowsFormsAppEimer
{
    partial class Form
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
            this.panelVoll = new System.Windows.Forms.Panel();
            this.panelLeer = new System.Windows.Forms.Panel();
            this.buttonHinzufügen = new System.Windows.Forms.Button();
            this.textBoxHinzufügen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMenge = new System.Windows.Forms.TextBox();
            this.buttonLeeren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelVoll
            // 
            this.panelVoll.BackColor = System.Drawing.Color.Red;
            this.panelVoll.Location = new System.Drawing.Point(82, 110);
            this.panelVoll.Name = "panelVoll";
            this.panelVoll.Size = new System.Drawing.Size(176, 230);
            this.panelVoll.TabIndex = 0;
            // 
            // panelLeer
            // 
            this.panelLeer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelLeer.Location = new System.Drawing.Point(80, 110);
            this.panelLeer.Name = "panelLeer";
            this.panelLeer.Size = new System.Drawing.Size(176, 190);
            this.panelLeer.TabIndex = 0;
            // 
            // buttonHinzufügen
            // 
            this.buttonHinzufügen.Location = new System.Drawing.Point(82, 65);
            this.buttonHinzufügen.Name = "buttonHinzufügen";
            this.buttonHinzufügen.Size = new System.Drawing.Size(179, 25);
            this.buttonHinzufügen.TabIndex = 1;
            this.buttonHinzufügen.Text = "Hinzufügen";
            this.buttonHinzufügen.UseVisualStyleBackColor = true;
            this.buttonHinzufügen.Click += new System.EventHandler(this.buttonHinzufügen_Click);
            // 
            // textBoxHinzufügen
            // 
            this.textBoxHinzufügen.Location = new System.Drawing.Point(327, 66);
            this.textBoxHinzufügen.Name = "textBoxHinzufügen";
            this.textBoxHinzufügen.Size = new System.Drawing.Size(165, 20);
            this.textBoxHinzufügen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "akt. Füllstand";
            // 
            // textBoxMenge
            // 
            this.textBoxMenge.Location = new System.Drawing.Point(327, 182);
            this.textBoxMenge.Name = "textBoxMenge";
            this.textBoxMenge.Size = new System.Drawing.Size(165, 20);
            this.textBoxMenge.TabIndex = 4;
            // 
            // buttonLeeren
            // 
            this.buttonLeeren.Location = new System.Drawing.Point(85, 368);
            this.buttonLeeren.Name = "buttonLeeren";
            this.buttonLeeren.Size = new System.Drawing.Size(407, 23);
            this.buttonLeeren.TabIndex = 5;
            this.buttonLeeren.Text = "Eimer leeren";
            this.buttonLeeren.UseVisualStyleBackColor = true;
            this.buttonLeeren.Click += new System.EventHandler(this.buttonLeeren_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.buttonLeeren);
            this.Controls.Add(this.textBoxMenge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxHinzufügen);
            this.Controls.Add(this.buttonHinzufügen);
            this.Controls.Add(this.panelLeer);
            this.Controls.Add(this.panelVoll);
            this.Name = "Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVoll;
        private System.Windows.Forms.Panel panelLeer;
        private System.Windows.Forms.Button buttonHinzufügen;
        private System.Windows.Forms.TextBox textBoxHinzufügen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMenge;
        private System.Windows.Forms.Button buttonLeeren;
    }
}

