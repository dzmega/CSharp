namespace WindowsFormsAppIP
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
            this.lstIP = new System.Windows.Forms.ListBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstOK = new System.Windows.Forms.ListBox();
            this.lstNichtOK = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text-Adressen";
            // 
            // lstIP
            // 
            this.lstIP.FormattingEnabled = true;
            this.lstIP.Location = new System.Drawing.Point(77, 95);
            this.lstIP.Name = "lstIP";
            this.lstIP.Size = new System.Drawing.Size(260, 173);
            this.lstIP.TabIndex = 1;
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(375, 95);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(316, 23);
            this.btnPing.TabIndex = 2;
            this.btnPing.Text = "ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ping OK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ping nicht OK";
            // 
            // lstOK
            // 
            this.lstOK.FormattingEnabled = true;
            this.lstOK.Location = new System.Drawing.Point(375, 173);
            this.lstOK.Name = "lstOK";
            this.lstOK.Size = new System.Drawing.Size(147, 95);
            this.lstOK.TabIndex = 5;
            // 
            // lstNichtOK
            // 
            this.lstNichtOK.FormattingEnabled = true;
            this.lstNichtOK.Location = new System.Drawing.Point(545, 173);
            this.lstNichtOK.Name = "lstNichtOK";
            this.lstNichtOK.Size = new System.Drawing.Size(145, 95);
            this.lstNichtOK.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 370);
            this.Controls.Add(this.lstNichtOK);
            this.Controls.Add(this.lstOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.lstIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstIP;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstOK;
        private System.Windows.Forms.ListBox lstNichtOK;
    }
}

