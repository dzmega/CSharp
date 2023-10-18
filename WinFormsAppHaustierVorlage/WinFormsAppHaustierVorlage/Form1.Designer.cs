namespace WinFormsAppHaustierVorlage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMenschLaune = new System.Windows.Forms.Label();
            this.labelTierLaune = new System.Windows.Forms.Label();
            this.buttonArbeiten = new System.Windows.Forms.Button();
            this.buttonHomeoffice = new System.Windows.Forms.Button();
            this.buttonUrlaub = new System.Windows.Forms.Button();
            this.buttonSaubermachen = new System.Windows.Forms.Button();
            this.buttonFuettern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tier";
            // 
            // labelMenschLaune
            // 
            this.labelMenschLaune.AutoSize = true;
            this.labelMenschLaune.Location = new System.Drawing.Point(32, 73);
            this.labelMenschLaune.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMenschLaune.Name = "labelMenschLaune";
            this.labelMenschLaune.Size = new System.Drawing.Size(25, 15);
            this.labelMenschLaune.TabIndex = 2;
            this.labelMenschLaune.Text = "xxx";
            // 
            // labelTierLaune
            // 
            this.labelTierLaune.AutoSize = true;
            this.labelTierLaune.Location = new System.Drawing.Point(316, 73);
            this.labelTierLaune.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTierLaune.Name = "labelTierLaune";
            this.labelTierLaune.Size = new System.Drawing.Size(25, 15);
            this.labelTierLaune.TabIndex = 3;
            this.labelTierLaune.Text = "xxx";
            // 
            // buttonArbeiten
            // 
            this.buttonArbeiten.Location = new System.Drawing.Point(24, 120);
            this.buttonArbeiten.Margin = new System.Windows.Forms.Padding(2);
            this.buttonArbeiten.Name = "buttonArbeiten";
            this.buttonArbeiten.Size = new System.Drawing.Size(140, 20);
            this.buttonArbeiten.TabIndex = 4;
            this.buttonArbeiten.Text = "Arbeiten";
            this.buttonArbeiten.UseVisualStyleBackColor = true;
            this.buttonArbeiten.Click += new System.EventHandler(this.buttonArbeiten_Click);
            // 
            // buttonHomeoffice
            // 
            this.buttonHomeoffice.Location = new System.Drawing.Point(24, 161);
            this.buttonHomeoffice.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHomeoffice.Name = "buttonHomeoffice";
            this.buttonHomeoffice.Size = new System.Drawing.Size(140, 20);
            this.buttonHomeoffice.TabIndex = 5;
            this.buttonHomeoffice.Text = "Homeoffice";
            this.buttonHomeoffice.UseVisualStyleBackColor = true;
            this.buttonHomeoffice.Click += new System.EventHandler(this.buttonHomeoffice_Click);
            // 
            // buttonUrlaub
            // 
            this.buttonUrlaub.Location = new System.Drawing.Point(26, 209);
            this.buttonUrlaub.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUrlaub.Name = "buttonUrlaub";
            this.buttonUrlaub.Size = new System.Drawing.Size(140, 20);
            this.buttonUrlaub.TabIndex = 6;
            this.buttonUrlaub.Text = "Urlaub";
            this.buttonUrlaub.UseVisualStyleBackColor = true;
            this.buttonUrlaub.Click += new System.EventHandler(this.buttonUrlaub_Click);
            // 
            // buttonSaubermachen
            // 
            this.buttonSaubermachen.Location = new System.Drawing.Point(290, 183);
            this.buttonSaubermachen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaubermachen.Name = "buttonSaubermachen";
            this.buttonSaubermachen.Size = new System.Drawing.Size(140, 20);
            this.buttonSaubermachen.TabIndex = 8;
            this.buttonSaubermachen.Text = "Saubermachen";
            this.buttonSaubermachen.UseVisualStyleBackColor = true;
            this.buttonSaubermachen.Click += new System.EventHandler(this.buttonSaubermachen_Click);
            // 
            // buttonFuettern
            // 
            this.buttonFuettern.Location = new System.Drawing.Point(288, 136);
            this.buttonFuettern.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFuettern.Name = "buttonFuettern";
            this.buttonFuettern.Size = new System.Drawing.Size(140, 20);
            this.buttonFuettern.TabIndex = 7;
            this.buttonFuettern.Text = "Fuettern";
            this.buttonFuettern.UseVisualStyleBackColor = true;
            this.buttonFuettern.Click += new System.EventHandler(this.buttonFuettern_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.buttonSaubermachen);
            this.Controls.Add(this.buttonFuettern);
            this.Controls.Add(this.buttonUrlaub);
            this.Controls.Add(this.buttonHomeoffice);
            this.Controls.Add(this.buttonArbeiten);
            this.Controls.Add(this.labelTierLaune);
            this.Controls.Add(this.labelMenschLaune);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelMenschLaune;
        private Label labelTierLaune;
        private Button buttonArbeiten;
        private Button buttonHomeoffice;
        private Button buttonUrlaub;
        private Button buttonSaubermachen;
        private Button buttonFuettern;
    }
}