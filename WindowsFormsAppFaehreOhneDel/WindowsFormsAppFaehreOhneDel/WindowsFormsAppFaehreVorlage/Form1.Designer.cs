namespace WindowsFormsAppFaehreVorlage
{
    partial class FormFaehre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFaehre));
            this.groupBoxLKW = new System.Windows.Forms.GroupBox();
            this.buttonLKWaufnehmen = new System.Windows.Forms.Button();
            this.textBoxLKWPreis = new System.Windows.Forms.TextBox();
            this.textBoxGesamtgewicht = new System.Windows.Forms.TextBox();
            this.labelLKWPreis = new System.Windows.Forms.Label();
            this.labelGesamtgewicht = new System.Windows.Forms.Label();
            this.groupBoxAuto = new System.Windows.Forms.GroupBox();
            this.buttonPKWaufnehmen = new System.Windows.Forms.Button();
            this.textBoxPreisAuto = new System.Windows.Forms.TextBox();
            this.textBoxPersonenanzahl = new System.Windows.Forms.TextBox();
            this.labelPreisAuto = new System.Windows.Forms.Label();
            this.labelPersonenanzahl = new System.Windows.Forms.Label();
            this.groupBoxFahrzeug = new System.Windows.Forms.GroupBox();
            this.textBoxFahrzeugLänge = new System.Windows.Forms.TextBox();
            this.textBoxKennzeichen = new System.Windows.Forms.TextBox();
            this.labelFahrzeugeLänge = new System.Windows.Forms.Label();
            this.labelKennzeichen = new System.Windows.Forms.Label();
            this.textBoxLeergewicht = new System.Windows.Forms.TextBox();
            this.labelLeergewicht = new System.Windows.Forms.Label();
            this.groupBoxFähre = new System.Windows.Forms.GroupBox();
            this.listBoxaufgenommeneFahrzeuge = new System.Windows.Forms.ListBox();
            this.labelaufgenommeneFahrzeuge = new System.Windows.Forms.Label();
            this.textBoxLänge = new System.Windows.Forms.TextBox();
            this.labelLänge = new System.Windows.Forms.Label();
            this.textBoxBelegteLaenge = new System.Windows.Forms.TextBox();
            this.labelBelegteBreite = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxLKW.SuspendLayout();
            this.groupBoxAuto.SuspendLayout();
            this.groupBoxFahrzeug.SuspendLayout();
            this.groupBoxFähre.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLKW
            // 
            this.groupBoxLKW.Controls.Add(this.buttonLKWaufnehmen);
            this.groupBoxLKW.Controls.Add(this.textBoxLKWPreis);
            this.groupBoxLKW.Controls.Add(this.textBoxGesamtgewicht);
            this.groupBoxLKW.Controls.Add(this.labelLKWPreis);
            this.groupBoxLKW.Controls.Add(this.labelGesamtgewicht);
            this.groupBoxLKW.Location = new System.Drawing.Point(399, 305);
            this.groupBoxLKW.Name = "groupBoxLKW";
            this.groupBoxLKW.Size = new System.Drawing.Size(337, 136);
            this.groupBoxLKW.TabIndex = 7;
            this.groupBoxLKW.TabStop = false;
            this.groupBoxLKW.Text = "LKW";
            // 
            // buttonLKWaufnehmen
            // 
            this.buttonLKWaufnehmen.Location = new System.Drawing.Point(13, 80);
            this.buttonLKWaufnehmen.Name = "buttonLKWaufnehmen";
            this.buttonLKWaufnehmen.Size = new System.Drawing.Size(313, 36);
            this.buttonLKWaufnehmen.TabIndex = 23;
            this.buttonLKWaufnehmen.Text = "LKW aufnehmen";
            this.buttonLKWaufnehmen.UseVisualStyleBackColor = true;
            this.buttonLKWaufnehmen.Click += new System.EventHandler(this.buttonLKWaufnehmen_Click);
            // 
            // textBoxLKWPreis
            // 
            this.textBoxLKWPreis.Location = new System.Drawing.Point(242, 21);
            this.textBoxLKWPreis.Name = "textBoxLKWPreis";
            this.textBoxLKWPreis.ReadOnly = true;
            this.textBoxLKWPreis.Size = new System.Drawing.Size(84, 20);
            this.textBoxLKWPreis.TabIndex = 22;
            // 
            // textBoxGesamtgewicht
            // 
            this.textBoxGesamtgewicht.Location = new System.Drawing.Point(90, 21);
            this.textBoxGesamtgewicht.Name = "textBoxGesamtgewicht";
            this.textBoxGesamtgewicht.Size = new System.Drawing.Size(100, 20);
            this.textBoxGesamtgewicht.TabIndex = 20;
            // 
            // labelLKWPreis
            // 
            this.labelLKWPreis.AutoSize = true;
            this.labelLKWPreis.Location = new System.Drawing.Point(206, 29);
            this.labelLKWPreis.Name = "labelLKWPreis";
            this.labelLKWPreis.Size = new System.Drawing.Size(30, 13);
            this.labelLKWPreis.TabIndex = 21;
            this.labelLKWPreis.Text = "Preis";
            // 
            // labelGesamtgewicht
            // 
            this.labelGesamtgewicht.AutoSize = true;
            this.labelGesamtgewicht.Location = new System.Drawing.Point(10, 29);
            this.labelGesamtgewicht.Name = "labelGesamtgewicht";
            this.labelGesamtgewicht.Size = new System.Drawing.Size(80, 13);
            this.labelGesamtgewicht.TabIndex = 19;
            this.labelGesamtgewicht.Text = "Gesamtgewicht";
            // 
            // groupBoxAuto
            // 
            this.groupBoxAuto.Controls.Add(this.buttonPKWaufnehmen);
            this.groupBoxAuto.Controls.Add(this.textBoxPreisAuto);
            this.groupBoxAuto.Controls.Add(this.textBoxPersonenanzahl);
            this.groupBoxAuto.Controls.Add(this.labelPreisAuto);
            this.groupBoxAuto.Controls.Add(this.labelPersonenanzahl);
            this.groupBoxAuto.Location = new System.Drawing.Point(399, 160);
            this.groupBoxAuto.Name = "groupBoxAuto";
            this.groupBoxAuto.Size = new System.Drawing.Size(337, 136);
            this.groupBoxAuto.TabIndex = 6;
            this.groupBoxAuto.TabStop = false;
            this.groupBoxAuto.Text = "Auto";
            // 
            // buttonPKWaufnehmen
            // 
            this.buttonPKWaufnehmen.Location = new System.Drawing.Point(18, 78);
            this.buttonPKWaufnehmen.Name = "buttonPKWaufnehmen";
            this.buttonPKWaufnehmen.Size = new System.Drawing.Size(313, 36);
            this.buttonPKWaufnehmen.TabIndex = 18;
            this.buttonPKWaufnehmen.Text = "Auto aufnehmen";
            this.buttonPKWaufnehmen.UseVisualStyleBackColor = true;
            this.buttonPKWaufnehmen.Click += new System.EventHandler(this.buttonPKWaufnehmen_Click);
            // 
            // textBoxPreisAuto
            // 
            this.textBoxPreisAuto.Location = new System.Drawing.Point(247, 19);
            this.textBoxPreisAuto.Name = "textBoxPreisAuto";
            this.textBoxPreisAuto.ReadOnly = true;
            this.textBoxPreisAuto.Size = new System.Drawing.Size(84, 20);
            this.textBoxPreisAuto.TabIndex = 17;
            // 
            // textBoxPersonenanzahl
            // 
            this.textBoxPersonenanzahl.Location = new System.Drawing.Point(95, 19);
            this.textBoxPersonenanzahl.Name = "textBoxPersonenanzahl";
            this.textBoxPersonenanzahl.Size = new System.Drawing.Size(100, 20);
            this.textBoxPersonenanzahl.TabIndex = 15;
            // 
            // labelPreisAuto
            // 
            this.labelPreisAuto.AutoSize = true;
            this.labelPreisAuto.Location = new System.Drawing.Point(211, 27);
            this.labelPreisAuto.Name = "labelPreisAuto";
            this.labelPreisAuto.Size = new System.Drawing.Size(30, 13);
            this.labelPreisAuto.TabIndex = 16;
            this.labelPreisAuto.Text = "Preis";
            // 
            // labelPersonenanzahl
            // 
            this.labelPersonenanzahl.AutoSize = true;
            this.labelPersonenanzahl.Location = new System.Drawing.Point(15, 27);
            this.labelPersonenanzahl.Name = "labelPersonenanzahl";
            this.labelPersonenanzahl.Size = new System.Drawing.Size(83, 13);
            this.labelPersonenanzahl.TabIndex = 14;
            this.labelPersonenanzahl.Text = "Personenanzahl";
            // 
            // groupBoxFahrzeug
            // 
            this.groupBoxFahrzeug.Controls.Add(this.textBoxFahrzeugLänge);
            this.groupBoxFahrzeug.Controls.Add(this.textBoxKennzeichen);
            this.groupBoxFahrzeug.Controls.Add(this.labelFahrzeugeLänge);
            this.groupBoxFahrzeug.Controls.Add(this.labelKennzeichen);
            this.groupBoxFahrzeug.Controls.Add(this.textBoxLeergewicht);
            this.groupBoxFahrzeug.Controls.Add(this.labelLeergewicht);
            this.groupBoxFahrzeug.Location = new System.Drawing.Point(399, 16);
            this.groupBoxFahrzeug.Name = "groupBoxFahrzeug";
            this.groupBoxFahrzeug.Size = new System.Drawing.Size(337, 136);
            this.groupBoxFahrzeug.TabIndex = 5;
            this.groupBoxFahrzeug.TabStop = false;
            this.groupBoxFahrzeug.Text = "Fahrzeug";
            // 
            // textBoxFahrzeugLänge
            // 
            this.textBoxFahrzeugLänge.Location = new System.Drawing.Point(95, 58);
            this.textBoxFahrzeugLänge.Name = "textBoxFahrzeugLänge";
            this.textBoxFahrzeugLänge.Size = new System.Drawing.Size(100, 20);
            this.textBoxFahrzeugLänge.TabIndex = 13;
            // 
            // textBoxKennzeichen
            // 
            this.textBoxKennzeichen.Location = new System.Drawing.Point(95, 19);
            this.textBoxKennzeichen.Name = "textBoxKennzeichen";
            this.textBoxKennzeichen.Size = new System.Drawing.Size(100, 20);
            this.textBoxKennzeichen.TabIndex = 9;
            // 
            // labelFahrzeugeLänge
            // 
            this.labelFahrzeugeLänge.AutoSize = true;
            this.labelFahrzeugeLänge.Location = new System.Drawing.Point(15, 66);
            this.labelFahrzeugeLänge.Name = "labelFahrzeugeLänge";
            this.labelFahrzeugeLänge.Size = new System.Drawing.Size(37, 13);
            this.labelFahrzeugeLänge.TabIndex = 12;
            this.labelFahrzeugeLänge.Text = "Länge";
            // 
            // labelKennzeichen
            // 
            this.labelKennzeichen.AutoSize = true;
            this.labelKennzeichen.Location = new System.Drawing.Point(15, 27);
            this.labelKennzeichen.Name = "labelKennzeichen";
            this.labelKennzeichen.Size = new System.Drawing.Size(69, 13);
            this.labelKennzeichen.TabIndex = 8;
            this.labelKennzeichen.Text = "Kennzeichen";
            // 
            // textBoxLeergewicht
            // 
            this.textBoxLeergewicht.Location = new System.Drawing.Point(95, 101);
            this.textBoxLeergewicht.Name = "textBoxLeergewicht";
            this.textBoxLeergewicht.Size = new System.Drawing.Size(100, 20);
            this.textBoxLeergewicht.TabIndex = 11;
            // 
            // labelLeergewicht
            // 
            this.labelLeergewicht.AutoSize = true;
            this.labelLeergewicht.Location = new System.Drawing.Point(15, 109);
            this.labelLeergewicht.Name = "labelLeergewicht";
            this.labelLeergewicht.Size = new System.Drawing.Size(65, 13);
            this.labelLeergewicht.TabIndex = 10;
            this.labelLeergewicht.Text = "Leergewicht";
            // 
            // groupBoxFähre
            // 
            this.groupBoxFähre.Controls.Add(this.listBoxaufgenommeneFahrzeuge);
            this.groupBoxFähre.Controls.Add(this.labelaufgenommeneFahrzeuge);
            this.groupBoxFähre.Controls.Add(this.textBoxLänge);
            this.groupBoxFähre.Controls.Add(this.labelLänge);
            this.groupBoxFähre.Controls.Add(this.textBoxBelegteLaenge);
            this.groupBoxFähre.Controls.Add(this.labelBelegteBreite);
            this.groupBoxFähre.Controls.Add(this.textBoxName);
            this.groupBoxFähre.Controls.Add(this.labelName);
            this.groupBoxFähre.Location = new System.Drawing.Point(14, 16);
            this.groupBoxFähre.Name = "groupBoxFähre";
            this.groupBoxFähre.Size = new System.Drawing.Size(364, 425);
            this.groupBoxFähre.TabIndex = 4;
            this.groupBoxFähre.TabStop = false;
            this.groupBoxFähre.Text = "Fähre";
            // 
            // listBoxaufgenommeneFahrzeuge
            // 
            this.listBoxaufgenommeneFahrzeuge.FormattingEnabled = true;
            this.listBoxaufgenommeneFahrzeuge.Location = new System.Drawing.Point(23, 222);
            this.listBoxaufgenommeneFahrzeuge.Name = "listBoxaufgenommeneFahrzeuge";
            this.listBoxaufgenommeneFahrzeuge.Size = new System.Drawing.Size(307, 173);
            this.listBoxaufgenommeneFahrzeuge.TabIndex = 7;
            // 
            // labelaufgenommeneFahrzeuge
            // 
            this.labelaufgenommeneFahrzeuge.AutoSize = true;
            this.labelaufgenommeneFahrzeuge.Location = new System.Drawing.Point(20, 205);
            this.labelaufgenommeneFahrzeuge.Name = "labelaufgenommeneFahrzeuge";
            this.labelaufgenommeneFahrzeuge.Size = new System.Drawing.Size(133, 13);
            this.labelaufgenommeneFahrzeuge.TabIndex = 6;
            this.labelaufgenommeneFahrzeuge.Text = "aufgenommene Fahrzeuge";
            // 
            // textBoxLänge
            // 
            this.textBoxLänge.Location = new System.Drawing.Point(102, 63);
            this.textBoxLänge.Name = "textBoxLänge";
            this.textBoxLänge.Size = new System.Drawing.Size(100, 20);
            this.textBoxLänge.TabIndex = 5;
            // 
            // labelLänge
            // 
            this.labelLänge.AutoSize = true;
            this.labelLänge.Location = new System.Drawing.Point(17, 71);
            this.labelLänge.Name = "labelLänge";
            this.labelLänge.Size = new System.Drawing.Size(37, 13);
            this.labelLänge.TabIndex = 4;
            this.labelLänge.Text = "Länge";
            // 
            // textBoxBelegteLaenge
            // 
            this.textBoxBelegteLaenge.Location = new System.Drawing.Point(102, 106);
            this.textBoxBelegteLaenge.Name = "textBoxBelegteLaenge";
            this.textBoxBelegteLaenge.ReadOnly = true;
            this.textBoxBelegteLaenge.Size = new System.Drawing.Size(100, 20);
            this.textBoxBelegteLaenge.TabIndex = 3;
            // 
            // labelBelegteBreite
            // 
            this.labelBelegteBreite.AutoSize = true;
            this.labelBelegteBreite.Location = new System.Drawing.Point(17, 114);
            this.labelBelegteBreite.Name = "labelBelegteBreite";
            this.labelBelegteBreite.Size = new System.Drawing.Size(76, 13);
            this.labelBelegteBreite.TabIndex = 2;
            this.labelBelegteBreite.Text = "Belegte Länge";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(102, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(17, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // FormFaehre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 466);
            this.Controls.Add(this.groupBoxLKW);
            this.Controls.Add(this.groupBoxAuto);
            this.Controls.Add(this.groupBoxFahrzeug);
            this.Controls.Add(this.groupBoxFähre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFaehre";
            this.Text = "Fähre";
            this.groupBoxLKW.ResumeLayout(false);
            this.groupBoxLKW.PerformLayout();
            this.groupBoxAuto.ResumeLayout(false);
            this.groupBoxAuto.PerformLayout();
            this.groupBoxFahrzeug.ResumeLayout(false);
            this.groupBoxFahrzeug.PerformLayout();
            this.groupBoxFähre.ResumeLayout(false);
            this.groupBoxFähre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLKW;
        private System.Windows.Forms.Button buttonLKWaufnehmen;
        private System.Windows.Forms.TextBox textBoxLKWPreis;
        private System.Windows.Forms.TextBox textBoxGesamtgewicht;
        private System.Windows.Forms.Label labelLKWPreis;
        private System.Windows.Forms.Label labelGesamtgewicht;
        private System.Windows.Forms.GroupBox groupBoxAuto;
        private System.Windows.Forms.Button buttonPKWaufnehmen;
        private System.Windows.Forms.TextBox textBoxPreisAuto;
        private System.Windows.Forms.TextBox textBoxPersonenanzahl;
        private System.Windows.Forms.Label labelPreisAuto;
        private System.Windows.Forms.Label labelPersonenanzahl;
        private System.Windows.Forms.GroupBox groupBoxFahrzeug;
        private System.Windows.Forms.TextBox textBoxFahrzeugLänge;
        private System.Windows.Forms.TextBox textBoxKennzeichen;
        private System.Windows.Forms.Label labelFahrzeugeLänge;
        private System.Windows.Forms.Label labelKennzeichen;
        private System.Windows.Forms.TextBox textBoxLeergewicht;
        private System.Windows.Forms.Label labelLeergewicht;
        private System.Windows.Forms.GroupBox groupBoxFähre;
        private System.Windows.Forms.ListBox listBoxaufgenommeneFahrzeuge;
        private System.Windows.Forms.Label labelaufgenommeneFahrzeuge;
        private System.Windows.Forms.TextBox textBoxLänge;
        private System.Windows.Forms.Label labelLänge;
        private System.Windows.Forms.TextBox textBoxBelegteLaenge;
        private System.Windows.Forms.Label labelBelegteBreite;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
    }
}

