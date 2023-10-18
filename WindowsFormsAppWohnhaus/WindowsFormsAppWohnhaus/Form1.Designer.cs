namespace WindowsFormsAppWohnhaus
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.anzeige = new System.Windows.Forms.Label();
            this.labelAusgabe = new System.Windows.Forms.Label();
            this.buttonEinziehen = new System.Windows.Forms.Button();
            this.buttonAusziehen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelWohnung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(97, 90);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(170, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // anzeige
            // 
            this.anzeige.AutoSize = true;
            this.anzeige.Location = new System.Drawing.Point(53, 222);
            this.anzeige.Name = "anzeige";
            this.anzeige.Size = new System.Drawing.Size(48, 13);
            this.anzeige.TabIndex = 2;
            this.anzeige.Text = "Anzeige:";
            // 
            // labelAusgabe
            // 
            this.labelAusgabe.AutoSize = true;
            this.labelAusgabe.Location = new System.Drawing.Point(107, 222);
            this.labelAusgabe.Name = "labelAusgabe";
            this.labelAusgabe.Size = new System.Drawing.Size(0, 13);
            this.labelAusgabe.TabIndex = 3;
            // 
            // buttonEinziehen
            // 
            this.buttonEinziehen.Location = new System.Drawing.Point(344, 74);
            this.buttonEinziehen.Name = "buttonEinziehen";
            this.buttonEinziehen.Size = new System.Drawing.Size(95, 52);
            this.buttonEinziehen.TabIndex = 4;
            this.buttonEinziehen.Text = "Einziehen";
            this.buttonEinziehen.UseVisualStyleBackColor = true;
            this.buttonEinziehen.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAusziehen
            // 
            this.buttonAusziehen.Location = new System.Drawing.Point(464, 74);
            this.buttonAusziehen.Name = "buttonAusziehen";
            this.buttonAusziehen.Size = new System.Drawing.Size(95, 53);
            this.buttonAusziehen.TabIndex = 5;
            this.buttonAusziehen.Text = "Ausziehen";
            this.buttonAusziehen.UseVisualStyleBackColor = true;
            this.buttonAusziehen.Click += new System.EventHandler(this.buttonAusziehen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wohnung:";
            // 
            // labelWohnung
            // 
            this.labelWohnung.AutoSize = true;
            this.labelWohnung.Location = new System.Drawing.Point(524, 222);
            this.labelWohnung.Name = "labelWohnung";
            this.labelWohnung.Size = new System.Drawing.Size(35, 13);
            this.labelWohnung.TabIndex = 7;
            this.labelWohnung.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelWohnung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAusziehen);
            this.Controls.Add(this.buttonEinziehen);
            this.Controls.Add(this.labelAusgabe);
            this.Controls.Add(this.anzeige);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label anzeige;
        private System.Windows.Forms.Label labelAusgabe;
        private System.Windows.Forms.Button buttonEinziehen;
        private System.Windows.Forms.Button buttonAusziehen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelWohnung;
    }
}

